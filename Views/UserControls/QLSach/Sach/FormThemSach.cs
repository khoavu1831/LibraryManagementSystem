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

namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    public partial class FormThemSach : Form
    {
        private readonly TheLoaiService _theLoaiService;
        private readonly TacGiaService _tacGiaService;
        private readonly NXBService _nxbService;
        public FormThemSach()
        {
            InitializeComponent();
            var context = new LibraryDbContext();

            var nxbRepo = new NXBRepository(context);
            var theLoaiRepo = new TheLoaiRepository(context);
            var tacGiaRepo = new TacGiaRepository(context);

            _theLoaiService = new TheLoaiService(theLoaiRepo);
            _tacGiaService = new TacGiaService(tacGiaRepo);
            _nxbService = new NXBService(nxbRepo);
        }
        private void formThemNhanVien_Load(object sender, EventArgs e)
        {
            var theLoaiList = _theLoaiService.GetAllTheLoai();
            var tacGiaList = _tacGiaService.GetAllTacGia();

            foreach (var theLoai in theLoaiList.ToArray())
            {
                checkedListBoxTheLoai.Items.Add(theLoai.TenTheloai ?? "");
            }

            foreach (var tacGia in tacGiaList.ToArray())
            {
                checkedListBoxTacGia.Items.Add(tacGia.TenTacGia ?? "");
            }
        }
    }
}
