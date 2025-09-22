using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Lấy toàn bộ sản phẩm
        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        // Lấy sản phẩm bằng Id
        public Product? GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        // Thêm sản phẩm 
        public Product AddProduct(Product product)
        {
            _productRepository.Add(product);
            return product;
        }

        // Update sản phẩm
        public Product UpdateProduct(Product product)
        {
            _productRepository.Update(product);
            return product;
        }

        // Tìm sản phẩm theo id
        public Product? SearchById(int id)
        {
            return _productRepository
                    .GetAll()
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
        }

        // Xóa sản phẩm theo id 
        public Product? DeleteProduct(int id)
        {
            return _productRepository.Delete(id);
        }
    }
}
