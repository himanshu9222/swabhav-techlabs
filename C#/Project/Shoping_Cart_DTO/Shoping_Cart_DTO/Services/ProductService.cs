using Shoping_Cart_DTO.Models;
using Shoping_Cart_DTO.Repositary;
using System.Collections.Generic;

namespace Shoping_Cart_DTO.Controllers
{
    public class ProductService
    {
        public List<Product> ProductList { get; set; }
        ProductReopsitary productrepositary;

        public ProductService()
        {
            //productrepositary = new ProductReopsitary(new ShopingDbContext());
            productrepositary = new ProductReopsitary(ShopingDbContext.Instance);
            ProductList = new List<Product>();
        }

        public List<Product> RetriveProductList()
        {
            ProductList = productrepositary.FetchData();
            return ProductList;
        }

        public Product GetProduct(int id)
        {
            return productrepositary.GetProduct(id);
        }

        public Product GetProduct(string name)
        {
            return productrepositary.GetProduct(name);
        }
    }
}