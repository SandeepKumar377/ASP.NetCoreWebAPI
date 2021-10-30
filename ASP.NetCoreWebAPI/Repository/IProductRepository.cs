using ASP.NetCoreWebAPI.Models;
using System.Collections.Generic;

namespace ASP.NetCoreWebAPI.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();
    }
}