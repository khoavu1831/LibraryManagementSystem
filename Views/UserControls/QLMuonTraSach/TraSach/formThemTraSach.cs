using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    public partial class FormThemTraSach : Form
    {
        private readonly LibraryDbContext _context;
        private readonly PhieuMuonService _phieuMuonService;
        private List<PhieuMuon> _danhSachPhieuMuonDangMuon;

        public FormThemTraSach()
        {
            InitializeComponent();

            _context = new LibraryDbContext();
            var phieuMuonRepo = new PhieuMuonRepository(_context);
            var chiTietRepo = new ChiTietPhieuMuonRepository(_context);
            var banSaoRepo = new BanSaoSachRepository(_context);
            var theThanhVienRepo = new TheThanhVienRepository(_context);

            _phieuMuonService = new PhieuMuonService(phieuMuonRepo, chiTietRepo, banSaoRepo, theThanhVienRepo);

            dateTimePickerNgayTra.Value = DateTime.Now;
            textBoxNhanVien.ReadOnly = true;
            textBoxThanhVien.ReadOnly = true;

            LoadPhieuMuonDangMuon();
        }

        private void LoadPhieuMuonDangMuon()
        {
            try
            {
                var allPhieuMuon = _phieuMuonService.GetAllPhieuMuon();
                _danhSachPhieuMuonDangMuon = allPhieuMuon
                    .Where(pm => pm.TrangThai == PhieuMuon.TrangThaiEnum.DangMuon ||
                                 pm.TrangThai == PhieuMuon.TrangThaiEnum.QuaHan)
                    .ToList();

                comboBoxIDPhieuMuon.DataSource = _danhSachPhieuMuonDangMuon;
                comboBoxIDPhieuMuon.DisplayMember = "IdPhieuMuon";
                comboBoxIDPhieuMuon.ValueMember = "IdPhieuMuon";

                comboBoxIDPhieuMuon.SelectedIndex = -1;
                textBoxNhanVien.Clear();
                textBoxThanhVien.Clear();
                flowLayoutPanelSach.Controls.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách phiếu mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxIDPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIDPhieuMuon.SelectedIndex == -1)
            {
                textBoxNhanVien.Clear();
                textBoxThanhVien.Clear();
                flowLayoutPanelSach.Controls.Clear();
                return;
            }

            var phieuMuon = comboBoxIDPhieuMuon.SelectedItem as PhieuMuon;
            if (phieuMuon == null) return;

            try
            {
                textBoxNhanVien.Text = phieuMuon.NhanVien?.TenNhanVien ?? "N/A";
                var docGia = _context.DocGias.FirstOrDefault(dg => dg.IdDocGia == phieuMuon.TheThanhVien.IdDocGia);
                textBoxThanhVien.Text = docGia?.TenDocGia ?? "N/A";

                LoadSachChuaTra(phieuMuon.IdPhieuMuon);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin phiếu mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSachChuaTra(int idPhieuMuon)
        {
            flowLayoutPanelSach.Controls.Clear();

            var chiTietChuaTra = _phieuMuonService.GetChiTietChuaTra(idPhieuMuon);

            foreach (var chiTiet in chiTietChuaTra)
            {
                var tenSach = chiTiet.BanSaoSach?.Sach?.TenSach ?? "N/A";
                var idBanSao = chiTiet.BanSaoSach?.IdBanSaoSach ?? "N/A";
                var displayName = $"{idBanSao} {tenSach}"; 
                var bookItemPanel = CreateBookItemControl(chiTiet.IdChiTietPhieuMuon, displayName);
                flowLayoutPanelSach.Controls.Add(bookItemPanel);
            }
        }

        private Panel CreateBookItemControl(int idChiTietPhieuMuon, string tenSach)
        {
            var panel = new Panel
            {
                Width = 500,
                Height = 30,
                Margin = new Padding(2),
                Tag = idChiTietPhieuMuon
            };

            var checkBox = new CheckBox
            {
                Location = new Point(2, 5),
                Width = 20,
                Height = 20,
                Tag = "checkbox"
            };

            var labelSach = new Label
            {
                Location = new Point(25, 7),
                Width = 350,
                Height = 20,
                Text = tenSach,
                AutoEllipsis = true
            };

            var comboBoxTinhTrang = new ComboBox
            {
                Location = new Point(380, 3),
                Width = 120,
                Height = 25,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Tag = "tinhTrang",
                Enabled = false 
            };
            comboBoxTinhTrang.Items.AddRange(new object[] { "Tốt", "Hư hỏng", "Mất" });
            comboBoxTinhTrang.SelectedIndex = -1; 

            checkBox.CheckedChanged += (s, e) =>
            {
                comboBoxTinhTrang.Enabled = checkBox.Checked;
                if (checkBox.Checked && comboBoxTinhTrang.SelectedIndex == -1)
                    comboBoxTinhTrang.SelectedIndex = 0; 
                else if (!checkBox.Checked)
                    comboBoxTinhTrang.SelectedIndex = -1; 
            };


            panel.Controls.Add(checkBox);
            panel.Controls.Add(labelSach);
            panel.Controls.Add(comboBoxTinhTrang);

            return panel;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxIDPhieuMuon.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var danhSachTra = new List<(int IdChiTietPhieuMuon, DateTime NgayTra, ChiTietPhieuMuon.TinhTrangTraEnum TinhTrangTra)>();

                foreach (Panel bookPanel in flowLayoutPanelSach.Controls)
                {
                    var checkBox = bookPanel.Controls.OfType<CheckBox>().FirstOrDefault(c => c.Tag?.ToString() == "checkbox");
                    var comboBoxTinhTrang = bookPanel.Controls.OfType<ComboBox>().FirstOrDefault(c => c.Tag?.ToString() == "tinhTrang");

                    if (checkBox != null && checkBox.Checked && comboBoxTinhTrang != null)
                    {
                        var idChiTiet = (int)bookPanel.Tag;
                        var ngayTra = dateTimePickerNgayTra.Value;
                        var tinhTrangStr = comboBoxTinhTrang.SelectedItem?.ToString() ?? "Tốt";

                        var tinhTrang = tinhTrangStr switch
                        {
                            "Tốt" => ChiTietPhieuMuon.TinhTrangTraEnum.Tot,
                            "Hư hỏng" => ChiTietPhieuMuon.TinhTrangTraEnum.HuHong,
                            "Mất" => ChiTietPhieuMuon.TinhTrangTraEnum.Mat,
                            _ => ChiTietPhieuMuon.TinhTrangTraEnum.Tot
                        };

                        danhSachTra.Add((idChiTiet, ngayTra, tinhTrang));
                    }
                }

                if (danhSachTra.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sách để trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _phieuMuonService.TraNhieuSach(danhSachTra);

                MessageBox.Show("Trả sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi trả sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
