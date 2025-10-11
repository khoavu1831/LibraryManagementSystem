using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    public partial class UcBanSaoSach : UserControl
    {
        private int _pageSize = 15;
        private int _currentPage = 1;
        private int _totalRecords = 0;
        private int _totalPages = 0;
        public UcBanSaoSach()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadPage(1);
        }
        private void LoadPage(int page)
        {
            _currentPage = page;

            using (var context = new LibraryDbContext())
            {
                var repo = new BanSaoSachRepository(context);
                var bssService = new BanSaoSachService(repo);

                _totalRecords = bssService.GetTotalRecords();
                _totalPages = (int)Math.Ceiling(_totalRecords / (double)_pageSize);

                var bssList = bssService.GetBanSaoSachByPage(_currentPage, _pageSize);

                var bssDataView = bssList.Select(bss => new
                {
                    IdBanSaoSach = bss.IdBanSaoSach,
                    IdSach = bss.IdSach,
                    TenSach = bss.Sach!.TenSach,
                    TrangThai = bss.TinhTrangSach
                }).ToList();

                dgvBanSaoSach.DataSource = bssDataView;
                labelTrang.Text = $"Trang {_currentPage}/{_totalPages}";
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var formSuaBSS = new FormSuaBSS())
            {
                formSuaBSS.ShowDialog(this);
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
                LoadPage(_currentPage - 1);
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
                LoadPage(_currentPage + 1);
        }
    }
}
