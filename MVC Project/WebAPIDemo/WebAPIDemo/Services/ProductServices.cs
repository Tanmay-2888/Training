using System.Collections.Generic;
using WebAPIDemo.Model;
using WebAPIDemo.Repossitories;

namespace WebAPIDemo.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _iProductRepo;
        // Injecition of Dependancy using constructor
        public ProductServices(IProductRepository iProductRepo)
        {
            _iProductRepo = iProductRepo;
        }
        public int AddProduct(Product prod)
        {
            return _iProductRepo.AddProduct(prod);
        }
        public int DeleteProduct(int id)
        {
            return _iProductRepo.DeleteProduct(id);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _iProductRepo.GetAllProducts();
        }
        public int ModifyProduct(Product prod)
        {
            return _iProductRepo.ModifyProduct(prod);
        }

    }
}
