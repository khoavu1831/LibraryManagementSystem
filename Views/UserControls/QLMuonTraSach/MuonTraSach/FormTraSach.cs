using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach
{
    public partial class FormTraSach : Form
    {
        private readonly BanSaoSachService _bssService;
        private readonly PhieuMuonService _phieuMuonService;
        private readonly MucPhatService _mucPhatService;
        private int _idPhieuMuon;
        private List<MucPhat> _mucPhatFixed;
        private MucPhat? _mucPhatPerDay;

        public FormTraSach(int idPhieuMuon)
        {
            InitializeComponent();
            _idPhieuMuon = idPhieuMuon;

            var context = new LibraryDbContext();
            var bssRepo = new BanSaoSachRepository(context);
            var pmRepo = new PhieuMuonRepository(context);
            var mpRepo = new MucPhatRepository(context);

            _bssService = new BanSaoSachService(bssRepo);
            _phieuMuonService = new PhieuMuonService(pmRepo);
            _mucPhatService = new MucPhatService(mpRepo);
        }

        private void FormTraSach_Load(object sender, EventArgs e)
        {
            LoadMucPhat();
            LoadSach();

            // Gắn sự kiện
            dgvChiTietMuon.CellValueChanged += DgvChiTietMuon_CellValueChanged;
            dgvChiTietMuon.CurrentCellDirtyStateChanged += DgvChiTietMuon_CurrentCellDirtyStateChanged;
            dgvChiTietMuon.EditingControlShowing += DgvChiTietMuon_EditingControlShowing;

            // Tính phạt trễ cho tất cả sách
            foreach (DataGridViewRow row in dgvChiTietMuon.Rows)
            {
                CalculateLateFine(row);
            }
        }

        private void LoadMucPhat()
        {
            _mucPhatFixed = _mucPhatService.GetAllMucPhat()
                .Where(mp => mp.LoaiPhat == MucPhat.LoaiPhatEnum.Fixed && mp.IsActive == 1)
                .ToList();

            _mucPhatPerDay = _mucPhatService.GetAllMucPhat()
                .FirstOrDefault(mp => mp.LoaiPhat == MucPhat.LoaiPhatEnum.PerDay && mp.IsActive == 1);
        }

        private void LoadSach()
        {
            dgvChiTietMuon.Columns.Clear();
            dgvChiTietMuon.AutoGenerateColumns = false;
            dgvChiTietMuon.AllowUserToAddRows = false;

            dgvChiTietMuon.Columns.Add("IdChiTietPhieuMuon", "ID CTPM");
            dgvChiTietMuon.Columns["IdChiTietPhieuMuon"].Visible = false;

            dgvChiTietMuon.Columns.Add("IdBanSaoSach", "Mã bản sao");
            dgvChiTietMuon.Columns.Add("TenSach", "Tên sách");
            dgvChiTietMuon.Columns.Add("NgayMuon", "Ngày mượn");
            dgvChiTietMuon.Columns.Add("NgayHenTra", "Ngày hẹn trả");
            dgvChiTietMuon.Columns.Add("TinhTrangSach", "Tình trạng hiện tại");

            var colTinhTrangTra = new DataGridViewComboBoxColumn
            {
                Name = "TinhTrangTra",
                HeaderText = "Tình trạng trả",
            };
            colTinhTrangTra.Items.AddRange("Tốt", "Hỏng", "Mất");
            dgvChiTietMuon.Columns.Add(colTinhTrangTra);

            var colMucPhat = new DataGridViewComboBoxColumn
            {
                Name = "MucPhat",
                HeaderText = "Mức phạt"
            };
            dgvChiTietMuon.Columns.Add(colMucPhat);

            var colPhatTre = new DataGridViewTextBoxColumn
            {
                Name = "PhatTre",
                HeaderText = "Phạt trễ hạn",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "N0"
                }
            };
            dgvChiTietMuon.Columns.Add(colPhatTre);

            var colTongPhat = new DataGridViewTextBoxColumn
            {
                Name = "TongPhat",
                HeaderText = "Tổng phạt (đ)",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            };
            dgvChiTietMuon.Columns.Add(colTongPhat);

            var colCheck = new DataGridViewCheckBoxColumn
            {
                Name = "Chon",
                HeaderText = "Trả"
            };
            dgvChiTietMuon.Columns.Add(colCheck);

            var phieuMuon = _phieuMuonService.GetPhieuMuonChiTiet(_idPhieuMuon);
            if (phieuMuon == null)
            {
                MessageBox.Show("Không tìm thấy phiếu mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            textBoxDocGia.Text = phieuMuon.TheThanhVien?.DocGia?.TenDocGia ?? "Không xác định";
            textBoxNgayMuon.Text = phieuMuon.NgayMuon.ToString("dd/MM/yyyy");
            textBoxNgayHenTra.Text = phieuMuon.NgayHenTra.ToString("dd/MM/yyyy");

            dgvChiTietMuon.Rows.Clear();

            foreach (var ct in phieuMuon.ChiTietPhieuMuons!
                         .Where(x => x.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra))
            {
                dgvChiTietMuon.Rows.Add(
                    ct.IdChiTietPhieuMuon,
                    ct.BanSaoSach?.IdBanSaoSach ?? "",
                    ct.BanSaoSach?.Sach?.TenSach ?? "Không rõ",
                    phieuMuon.NgayMuon.ToString("dd/MM/yyyy"),
                    phieuMuon.NgayHenTra.ToString("dd/MM/yyyy"),
                    ct.BanSaoSach?.TinhTrangSach.ToString() ?? "Không rõ",
                    "Tốt",
                    "",
                    0,
                    0,
                    false
                );

                // Khóa chọn mức phạt khi mặc định tình trạng là "Tốt"
                var addedRow = dgvChiTietMuon.Rows[dgvChiTietMuon.Rows.Count - 1];
                var mpCell = (DataGridViewComboBoxCell)addedRow.Cells["MucPhat"];
                mpCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                addedRow.Cells["MucPhat"].ReadOnly = true;
            }

            foreach (DataGridViewColumn col in dgvChiTietMuon.Columns)
            {
                col.ReadOnly = !(col.Name == "TinhTrangTra" || col.Name == "MucPhat" || col.Name == "Chon");
            }
        }

        private void DgvChiTietMuon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dgvChiTietMuon.Rows[e.RowIndex];
            var colName = dgvChiTietMuon.Columns[e.ColumnIndex].Name;

            if (colName == "TinhTrangTra")
            {
                string tinhTrangTra = row.Cells["TinhTrangTra"].Value?.ToString() ?? "Tốt";

                var mpCell = (DataGridViewComboBoxCell)row.Cells["MucPhat"];
                if (tinhTrangTra == "Tốt")
                {
                    row.Cells["MucPhat"].Value = "";
                    row.Cells["MucPhat"].ReadOnly = true;
                    mpCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                }
                else
                {
                    row.Cells["MucPhat"].ReadOnly = false;
                    mpCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                    LoadMucPhatToComboBox(row);

                    // Chuyển focus sang cột Mức phạt và mở dropdown ngay
                    dgvChiTietMuon.CurrentCell = row.Cells["MucPhat"];
                    dgvChiTietMuon.BeginEdit(true);
                    if (dgvChiTietMuon.EditingControl is ComboBox cb)
                    {
                        cb.DropDownStyle = ComboBoxStyle.DropDownList;
                        cb.DroppedDown = true;
                    }
                }

                CalculateLateFine(row);
                CalculateTotalFine(row);
            }
            else if (colName == "MucPhat")
            {
                CalculateTotalFine(row);
            }
        }

        private void DgvChiTietMuon_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dgvChiTietMuon.IsCurrentCellDirty)
                dgvChiTietMuon.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void DgvChiTietMuon_EditingControlShowing(object? sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvChiTietMuon.CurrentCell?.OwningColumn?.Name == "MucPhat" && e.Control is ComboBox cb)
            {
                cb.BeginUpdate();
                cb.Items.Clear();
                cb.Items.AddRange(_mucPhatFixed
                    .Select(mp => $"{mp.TenMucPhat} - {mp.SoTienPhat:N0}đ")
                    .ToArray());
                cb.EndUpdate();
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void LoadMucPhatToComboBox(DataGridViewRow row)
        {
            var comboCell = row.Cells["MucPhat"] as DataGridViewComboBoxCell;
            if (comboCell == null) return;

            comboCell.Items.Clear();
            foreach (var mp in _mucPhatFixed)
            {
                comboCell.Items.Add($"{mp.TenMucPhat} - {mp.SoTienPhat:N0}đ");
            }
        }

        private void CalculateLateFine(DataGridViewRow row)
        {
            try
            {
                string ngayHenTraStr = row.Cells["NgayHenTra"].Value?.ToString() ?? "";
                if (!DateTime.TryParseExact(ngayHenTraStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngayHenTra))
                    return;

                decimal phatTre = 0;
                if (DateTime.Now > ngayHenTra && _mucPhatPerDay != null)
                {
                    int soNgayTre = (DateTime.Now - ngayHenTra).Days;
                    phatTre = _mucPhatPerDay.SoTienPhat * soNgayTre;
                }

                row.Cells["PhatTre"].Value = phatTre;
                CalculateTotalFine(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tính phạt trễ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotalFine(DataGridViewRow row)
        {
            try
            {
                decimal phatTre = Convert.ToDecimal(row.Cells["PhatTre"].Value ?? 0);
                decimal phatFixed = 0;

                string tinhTrangTra = row.Cells["TinhTrangTra"].Value?.ToString() ?? "Tốt";
                if (tinhTrangTra != "Tốt")
                {
                    string mucPhatStr = row.Cells["MucPhat"].Value?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(mucPhatStr))
                    {
                        var parts = mucPhatStr.Split('-');
                        if (parts.Length >= 2)
                        {
                            string tienStr = parts[1].Replace("đ", "").Trim();
                            if (decimal.TryParse(tienStr, out decimal tien))
                            {
                                phatFixed = tien;
                            }
                        }
                    }
                }

                row.Cells["TongPhat"].Value = phatTre + phatFixed;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tính tổng phạt: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // private void btnXacNhan_Click(object sender, EventArgs e)
        // {
        //     bool daTra = false;

        //     foreach (DataGridViewRow row in dgvChiTietMuon.Rows)
        //     {
        //         bool chon = Convert.ToBoolean(row.Cells["Chon"].Value);
        //         if (!chon) continue;

        //         int idCTPM = Convert.ToInt32(row.Cells["IdChiTietPhieuMuon"].Value);
        //         string tinhTrangTra = row.Cells["TinhTrangTra"].Value?.ToString() ?? "Tốt";

        //         int? idMucPhatFixed = null;
        //         if (!string.Equals(tinhTrangTra, "Tốt", StringComparison.OrdinalIgnoreCase))
        //         {
        //             string mucPhatStr = row.Cells["MucPhat"].Value?.ToString() ?? "";
        //             if (string.IsNullOrWhiteSpace(mucPhatStr))
        //             {
        //                 MessageBox.Show("Vui lòng chọn mức phạt cho sách không ở tình trạng Tốt.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                 return;
        //             }
        //             var mp = _mucPhatFixed.FirstOrDefault(x => mucPhatStr.Contains(x.TenMucPhat ?? "", StringComparison.OrdinalIgnoreCase));
        //             if (mp != null) idMucPhatFixed = mp.IdMucPhat;
        //         }

        //         _phieuMuonService.TraSach(idCTPM, tinhTrangTra);
        //         daTra = true;
        //     }

        //     if (daTra)
        //     {
        //         MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //         this.DialogResult = DialogResult.OK;
        //         this.Close();
        //     }
        //     else
        //     {
        //         MessageBox.Show("Vui lòng chọn ít nhất một sách để trả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //     }
        // }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool daTra = false;

            foreach (DataGridViewRow row in dgvChiTietMuon.Rows)
            {
                bool chon = Convert.ToBoolean(row.Cells["Chon"].Value);
                if (!chon) continue;

                int idCTPM = Convert.ToInt32(row.Cells["IdChiTietPhieuMuon"].Value);
                string tinhTrangTra = row.Cells["TinhTrangTra"].Value?.ToString() ?? "Tốt";

                int? idMucPhatFixed = null;
                if (!string.Equals(tinhTrangTra, "Tốt", StringComparison.OrdinalIgnoreCase))
                {
                    string mucPhatStr = row.Cells["MucPhat"].Value?.ToString() ?? "";
                    if (string.IsNullOrWhiteSpace(mucPhatStr))
                    {
                        MessageBox.Show("Vui lòng chọn mức phạt cho sách không ở tình trạng Tốt.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var mp = _mucPhatFixed.FirstOrDefault(x =>
                        mucPhatStr.StartsWith(x.TenMucPhat ?? "", StringComparison.OrdinalIgnoreCase));
                    if (mp == null)
                    {
                        MessageBox.Show("Không xác định được mức phạt cố định. Vui lòng chọn lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    idMucPhatFixed = mp.IdMucPhat;
                }

                _phieuMuonService.TraSachWithFixed(idCTPM, tinhTrangTra, idMucPhatFixed);
                daTra = true;
            }

            if (daTra)
            {
                MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sách để trả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
