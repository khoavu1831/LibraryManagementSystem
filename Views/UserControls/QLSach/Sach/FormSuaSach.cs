using LMS.Data;
using LMS.Entities;
using LMS.Repository;
using LMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLSach
{
    public partial class FormSuaSach : Form
    {
        private readonly int _idSach;
        private Sach? _sach;
        private readonly LibraryDbContext _context;
        private readonly TheLoaiService _theLoaiService;
        private readonly TacGiaService _tacGiaService;
        private readonly NXBService _nxbService;
        private readonly SachService _sachService;

        public FormSuaSach(int idSach)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            _idSach = idSach;

            _context = new LibraryDbContext();
            var theLoaiRepo = new TheLoaiRepository(_context);
            var tacGiaRepo = new TacGiaRepository(_context);
            var nxbRepo = new NXBRepository(_context);
            var sachRepo = new SachRepository(_context);

            _theLoaiService = new TheLoaiService(theLoaiRepo);
            _tacGiaService = new TacGiaService(tacGiaRepo);
            _nxbService = new NXBService(nxbRepo);
            _sachService = new SachService(sachRepo);

            Load += formSuaSach_Load;
        }

        private void formSuaSach_Load(object? sender, EventArgs e)
        {
            _sach = _sachService.GetSachById(_idSach);
            if (_sach == null)
            {
                MessageBox.Show("Không tìm thấy sách trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            LoadNXB();
            LoadTheLoai();
            LoadTacGia();
            BindData();
        }

        private void LoadNXB()
        {
            var nxbList = _nxbService.GetAllNXB();
            comboBoxNXB.DataSource = nxbList;
            comboBoxNXB.DisplayMember = "TenNXB";
            comboBoxNXB.ValueMember = "IdNXB";
        }

        private void LoadTheLoai()
        {
            checkedListBoxTheLoai.Items.Clear();
            var theLoaiList = _theLoaiService.GetAllTheLoai();

                foreach (var tl in theLoaiList)
            {
                var index = checkedListBoxTheLoai.Items.Add(tl);
                // nếu sách hiện tại có thể loại này thì check
                if (_sach!.TheLoais != null && _sach.TheLoais.Any(x => x.IdTheLoai == tl.IdTheLoai))
                {
                    checkedListBoxTheLoai.SetItemChecked(index, true);
                }
            }

            checkedListBoxTheLoai.DisplayMember = "TenTheloai";
        }

        private void LoadTacGia()
        {
            checkedListBoxTacGia.Items.Clear();
            var tacGiaList = _tacGiaService.GetAllTacGia();

                foreach (var tg in tacGiaList)
            {
                var index = checkedListBoxTacGia.Items.Add(tg);
                if (_sach!.TacGias != null && _sach.TacGias.Any(x => x.IdTacGia == tg.IdTacGia))
                {
                    checkedListBoxTacGia.SetItemChecked(index, true);
                }
            }

            checkedListBoxTacGia.DisplayMember = "TenTacGia";
        }

        private void BindData()
        {
            if (_sach == null) return;

            textBoxTenSach.Text = _sach.TenSach ?? string.Empty;
            numericUpDownNamXB.Value = _sach.NamXuatBan;
            numericUpDownSoTrang.Value = _sach.SoTrang;
            textBoxMoTa.Text = _sach.MoTa ?? string.Empty;
            textBoxGiaSach.Text = _sach.GiaTien.ToString("N0");

            if (_sach.NXB != null)
            {
                comboBoxNXB.SelectedValue = _sach.NXB.IdNXB;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sach == null)
                {
                    MessageBox.Show("Không xác định được sách cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // cập nhật các thuộc tính cho sách, trừ giá (readonly)
                _sach.TenSach = textBoxTenSach.Text.Trim();
                _sach.NamXuatBan = (int)numericUpDownNamXB.Value;
                _sach.SoTrang = (int)numericUpDownSoTrang.Value;
                _sach.MoTa = textBoxMoTa.Text.Trim();

                if (comboBoxNXB.SelectedItem is NXB nxb)
                {
                    _sach.NXB = nxb;
                    _sach.IdNXB = nxb.IdNXB;
                }

                // thể loại được chọn
                var selectedTheLoais = checkedListBoxTheLoai.CheckedItems.Cast<TheLoai>().ToList();
                _sach.TheLoais = selectedTheLoais;

                // tác giả được chọn
                var selectedTacGias = checkedListBoxTacGia.CheckedItems.Cast<TacGia>().ToList();
                _sach.TacGias = selectedTacGias;

                _sachService.UpdateSach(_sach);

                MessageBox.Show("Cập nhật sách thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
