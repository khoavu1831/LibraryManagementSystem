    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem.Views.UserControls.QLNhapSach
{
    public partial class FormThemPhieuNhap : Form
    {
        private readonly SachService _sachService;
        private readonly NCCService _nccService;
        public FormThemPhieuNhap()
        {
            InitializeComponent();

            var context = new LibraryDbContext();
            var sachRepo = new SachRepository(context);
            var nccRepo = new NCCRepository(context);

            _sachService = new SachService(sachRepo);
            _nccService = new NCCService(nccRepo);
        }

        private void FormThemPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadNCC();
            LoadSach();
        }
        private void LoadNCC()
        {
            var nccList = _nccService.GetAllNCC();
            nccList.ForEach(ncc => comboBoxNCC.Items.Add(ncc.TenNCC!));
        }
        private void LoadSach()
        {
            //var sachList = _sachService.GetAllSach()
            //    .Select(s => new
            //    {
            //        s.IdSach,
            //        s.TenSach,
            //        SoLuongTon = 
            //    });

        }
    }
}
