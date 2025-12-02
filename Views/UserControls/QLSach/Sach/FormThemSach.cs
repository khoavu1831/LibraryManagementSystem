using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Data;
using LMS.Entities;
using LMS.Repository;
using LMS.Services;

namespace LMS.Views.UserControls.QLSach
{
    public partial class FormThemSach : Form
    {
        private readonly TheLoaiService _theLoaiService;
        private readonly TacGiaService _tacGiaService;
        private readonly NXBService _nxbService;
        private readonly SachService _sachService;
        public FormThemSach()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            var context = new LibraryDbContext();

            var nxbRepo = new NXBRepository(context);
            var theLoaiRepo = new TheLoaiRepository();
            var tacGiaRepo = new TacGiaRepository(context);
            var sachRepo = new SachRepository(context);

            _theLoaiService = new TheLoaiService(theLoaiRepo);
            _tacGiaService = new TacGiaService(tacGiaRepo);
            _nxbService = new NXBService(nxbRepo);
            _sachService = new SachService(sachRepo);
        }
        private void formThemSach_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
            LoadTacGia();
            LoadNXB();
        }
        private void LoadTheLoai()
        {
            var theLoaiList = _theLoaiService.GetAllTheLoai();
            theLoaiList.ForEach(tl => checkedListBoxTheLoai.Items.Add(tl.TenTheloai ?? ""));
        }
        private void LoadTacGia()
        {
            var tacGiaList = _tacGiaService.GetAllTacGia();
            tacGiaList.ForEach(tg => checkedListBoxTacGia.Items.Add(tg.TenTacGia ?? ""));
        }
        private void LoadNXB()
        {
            var nxbList = _nxbService.GetAllNXB();
            comboBoxNXB.DataSource = nxbList;
            comboBoxNXB.DisplayMember = "TenNXB";
            comboBoxNXB.ValueMember = "IdNXB";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy các tên đã chọn trong danh sách theloai + tacgia
            var selectedNameTheLoais = checkedListBoxTheLoai.CheckedItems.Cast<string>().ToList();
            var selectedNameTacGias = checkedListBoxTacGia.CheckedItems.Cast<string>().ToList();

            // Gán dữ liệu cho các thuộc tính của Sách
            var tenSach = textBoxTenSach.Text.Trim();
            var theLoais = _theLoaiService.GetAllTheLoai()
                            .Where(tl => selectedNameTheLoais.Contains(tl.TenTheloai ?? ""))
                            .ToList();
            var tacGias = _tacGiaService.GetAllTacGia()
                            .Where(tg => selectedNameTacGias.Contains(tg.TenTacGia ?? ""))
                            .ToList();
            var nxb = (NXB)comboBoxNXB.SelectedItem!;
            var namXuatBan = (int)numericUpDownNamXB.Value;
            var soTrang = (int)numericUpDownSoTrang.Value;
            var moTa = textBoxMoTa.Text.Trim();
            var giaTien = Convert.ToDecimal(textBoxGiaSach.Text);

            try
            {
                var sach = new Sach
                {
                    TenSach = tenSach,
                    TheLoais = theLoais,
                    TacGias = tacGias,
                    NXB = nxb,
                    NamXuatBan = namXuatBan,
                    SoTrang = soTrang,
                    MoTa = moTa,
                    GiaTien = giaTien
                };

                _sachService.AddSach(sach);
                MessageBox.Show("Thêm sách thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
