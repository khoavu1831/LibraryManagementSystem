using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Repository.Implementations;
using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSystem.Forms
{
    public partial class NXBFormTest : Form
    {
        private readonly NXBService _nxbService;
        public NXBFormTest()
        {
            InitializeComponent();
            var context = new LibraryDbContext();
            var repo = new Repository<NXB>(context);
            _nxbService = new NXBService(repo);
        }


        private void NXBFormTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private async void LoadData()
        {
            var nxbs = await _nxbService.GetAllAsync();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nxbs;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void themBtn_Click(object sender, EventArgs e)
        {
            var nxb = new NXB()
            {
                TenNXB = tenTxtBox.Text,
                DiaChi = diachiTxtBox.Text,
                SDT = sdtTxtBox.Text
            };
            await _nxbService.AddAsync(nxb);
            MessageBox.Show($"Đã thêm nxb {nxb.TenNXB}");
            LoadData();
        }

        private async void suaBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idTxtBox.Text, out int id))
            {
                var n = await _nxbService.GetByIdAsync(id);
                if (n != null)
                {
                    n.TenNXB = tenTxtBox.Text;
                    n.SDT = sdtTxtBox.Text;
                    n.DiaChi = diachiTxtBox.Text;
                    var result = await _nxbService.UpdateAsync(n);
                    MessageBox.Show($"Đã sửa nxb {result.IdNXB}");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nxb");
                }
            }
        }

        private async void xoaBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idTxtBox.Text, out int id))
            {
                var result = await _nxbService.DeleteByIdAsync(id);
                if (result == null)
                {
                    MessageBox.Show($"Không tìm thấy nxb");
                    LoadData();
                    return;
                }
                MessageBox.Show($"Đã xóa nxb {result.TenNXB}");
                LoadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                idTxtBox.Text = row.Cells["IdNXB"].Value?.ToString();
                tenTxtBox.Text = row.Cells["TenNXB"].Value?.ToString();
                sdtTxtBox.Text = row.Cells["SDT"].Value?.ToString();
                diachiTxtBox.Text = row.Cells["DiaChi"].Value?.ToString();
            }
            else
            {
                idTxtBox.Text = "";
            }
        }
    }
}
