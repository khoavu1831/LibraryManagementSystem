using LMS.Data;
using LMS.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLPhat
{
    public partial class FormChiTietPhieuPhat : Form
    {
        private readonly int _idPhieuPhat;

        public FormChiTietPhieuPhat(int idPhieuPhat)
        {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterParent;

            _idPhieuPhat = idPhieuPhat;
		this.Load += FormChiTietPhieuPhat_Load;
	    }

        private void FormChiTietPhieuPhat_Load(object? sender, EventArgs e)
        {
            LoadHeader();
            LoadDetails();
        }

        private void LoadHeader()
        {
            using (var ctx = new LibraryDbContext())
            {
                var pp = ctx.PhieuPhats
                    .Include(x => x.ChiTietPhieuPhats!)
                        .ThenInclude(ct => ct.ChiTietPhieuMuon!)
                            .ThenInclude(ctpm => ctpm.PhieuMuon!)
                                .ThenInclude(pm => pm.TheThanhVien!)
                                    .ThenInclude(ttv => ttv.DocGia)
                    .AsNoTracking()
                    .FirstOrDefault(x => x.IdPhieuPhat == _idPhieuPhat);

                if (pp == null) { MessageBox.Show("Không tìm thấy phiếu phạt."); Close(); return; }

                // Gán các control phần header (đổi tên theo control bạn có sẵn)
                textBoxIDPhieuPhat.Text = pp.IdPhieuPhat.ToString();
                dateTimePickerNgayLap.Value = pp.NgayLap;
                textBoxDocGia.Text = pp.ChiTietPhieuPhats?
                    .Select(x => x.ChiTietPhieuMuon?.PhieuMuon?.TheThanhVien?.DocGia?.TenDocGia)
                    .FirstOrDefault(n => !string.IsNullOrWhiteSpace(n)) ?? "";

                // Nếu có thêm ô trạng thái, tổng tiền:
                textBoxTrangThai.Text = pp.TrangThai.GetDisplayName();
                textBoxTongTienPhat.Text = (pp.ChiTietPhieuPhats?.Sum(x => x.TienPhatTra) ?? 0m).ToString("N0");
            }
        }

        private void LoadDetails()
        {
            using (var ctx = new LibraryDbContext())
            {
                var data = ctx.ChiTietPhieuPhats
                    .Include(ct => ct.ChiTietPhieuMuon!)
                        .ThenInclude(ctpm => ctpm.BanSaoSach!)
                            .ThenInclude(bss => bss.Sach)
                    .Include(ct => ct.MucPhat)
                    .AsNoTracking()
                    .Where(ct => ct.IdPhieuPhat == _idPhieuPhat)
                    .Select(ct => new
                    {
                        IdChiTietPhieuPhat = ct.IdChiTietPhieuPhat,
                        TenSach = ct.ChiTietPhieuMuon!.BanSaoSach!.Sach!.TenSach,
                        IdChiTietPhieuMuon = ct.IdChiTietPhieuMuon,
                        TenMucPhat = ct.MucPhat!.TenMucPhat,
                        SoNgayTreHen = ct.SoNgayTreHen,
                        TienPhatTra = ct.TienPhatTra
                    })
                    .ToList();

                dgvChiTietPhieuPhat.Columns.Clear();
                dgvChiTietPhieuPhat.AutoGenerateColumns = true;
                dgvChiTietPhieuPhat.DataSource = data;

                dgvChiTietPhieuPhat.Columns["IdChiTietPhieuPhat"].HeaderText = "Mã chi tiết";
                dgvChiTietPhieuPhat.Columns["TenSach"].HeaderText = "Tên sách";
                dgvChiTietPhieuPhat.Columns["IdChiTietPhieuMuon"].HeaderText = "Mã CTPM";
                dgvChiTietPhieuPhat.Columns["TenMucPhat"].HeaderText = "Loại phạt";
                dgvChiTietPhieuPhat.Columns["SoNgayTreHen"].HeaderText = "Số ngày trễ";
                dgvChiTietPhieuPhat.Columns["TienPhatTra"].HeaderText = "Tiền phạt";
                dgvChiTietPhieuPhat.Columns["TienPhatTra"].DefaultCellStyle.Format = "N0";
                dgvChiTietPhieuPhat.Columns["TienPhatTra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTienPhat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
