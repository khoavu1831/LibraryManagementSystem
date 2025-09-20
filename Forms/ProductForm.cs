using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class ProductForm : Form
    {
        private readonly ProductService _productService;
        public ProductForm()
        {
            InitializeComponent();
            var dbContext = new LibraryDbContext();
            var repo = new ProductRepository(dbContext);
            _productService = new ProductService(repo);
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var products = _productService.GetAllProducts();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product() { Name = txtName.Text };

            var rs = _productService.AddProduct(product);
            MessageBox.Show($"Đã thêm sản phẩm {rs.Name}");
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                var p = _productService.GetProductById(id);
                if (p != null)
                {
                    p.Name = txtName.Text;
                    var result = _productService.UpdateProduct(p);
                    MessageBox.Show($"Đã sửa sản phẩm {result.Id}");
                    LoadData();
                } else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                var result = _productService.DeleteProduct(id);
                MessageBox.Show($"Đã xóa sản phẩm {result.Name}");
                LoadData();
            }
        }
    }
}
