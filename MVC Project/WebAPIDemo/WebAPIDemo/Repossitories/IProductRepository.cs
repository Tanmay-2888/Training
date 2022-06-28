using System.Collections.Generic;
using WebAPIDemo.Model;

namespace WebAPIDemo.Repossitories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        int AddProduct(Product prod);
        int ModifyProduct(Product prod);
        int DeleteProduct(int id);

    }
}
