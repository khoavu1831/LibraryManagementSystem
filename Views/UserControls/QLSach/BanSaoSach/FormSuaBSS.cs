using LMS.Data;
using LMS.Entities;
using LMS.Helpers;
using LMS.Repository;
using LMS.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLSach
{
    public partial class FormSuaBSS : Form
    {
        private readonly string _idBanSaoSach;
        private readonly string _tenSach;
        private readonly LibraryDbContext _context;
        private readonly BanSaoSachService _banSaoSachService;
        private BanSaoSach? _banSaoSach;

        public FormSuaBSS(string idBanSaoSach, string tenSach)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            _idBanSaoSach = idBanSaoSach;
            _tenSach = tenSach;

            _context = new LibraryDbContext();
            var repo = new BanSaoSachRepository(_context);
            _banSaoSachService = new BanSaoSachService(repo);

            Load += FormSuaBSS_Load;
            btnSua.Click += btnSua_Click;
            btnHuy.Click += btnHuy_Click;
        }

        private void FormSuaBSS_Load(object? sender, EventArgs e)
        {
            _banSaoSach = _banSaoSachService.GetBanSaoSachById(_idBanSaoSach);
            if (_banSaoSach == null)
            {
                MessageBox.Show("Không tìm thấy bản sao sách trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            // Hiển thị tên sách
            var sach = _context.Sachs.Find(_banSaoSach.IdSach);
            textBoxTenSach.Text = sach?.TenSach ?? _tenSach;

            // Bind combobox tình trạng với DisplayName, KHÔNG cho chọn trạng thái ChoMuon
            var tinhTrangList = Enum.GetValues(typeof(BanSaoSach.TinhTrangSachEnum))
                .Cast<BanSaoSach.TinhTrangSachEnum>()
                .Where(e => e != BanSaoSach.TinhTrangSachEnum.ChoMuon)
                .Select(e => new
                {
                    Value = e,
                    Display = e.GetDisplayName()
                })
                .ToList();

            comboBoxTinhTrang.DataSource = tinhTrangList;
            comboBoxTinhTrang.DisplayMember = "Display";
            comboBoxTinhTrang.ValueMember = "Value";
            comboBoxTinhTrang.SelectedValue = _banSaoSach.TinhTrangSach;

            // Nếu đang cho mượn thì không cho sửa tay
            if (_banSaoSach.TinhTrangSach == BanSaoSach.TinhTrangSachEnum.ChoMuon)
            {
                comboBoxTinhTrang.Enabled = false;
                btnSua.Enabled = false;
                MessageBox.Show("Bản sao đang được cho mượn. Vui lòng đổi tình trạng thông qua luồng trả sách.", "Không thể sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (_banSaoSach == null)
            {
                MessageBox.Show("Không xác định được bản sao sách cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxTinhTrang.SelectedValue is not BanSaoSach.TinhTrangSachEnum newStatus)
            {
                MessageBox.Show("Vui lòng chọn tình trạng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Không cho đổi sang trạng thái Cho Mượn trong form sửa
            if (newStatus == BanSaoSach.TinhTrangSachEnum.ChoMuon)
            {
                MessageBox.Show("Không thể chuyển bản sao sang trạng thái 'Cho mượn' tại đây. Hãy sử dụng luồng lập phiếu mượn.", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newStatus == _banSaoSach.TinhTrangSach)
            {
                MessageBox.Show("Tình trạng không thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _banSaoSach.TinhTrangSach = newStatus;
                _banSaoSachService.UpdateBanSaoSach(_banSaoSach);

                MessageBox.Show("Cập nhật tình trạng bản sao sách thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
