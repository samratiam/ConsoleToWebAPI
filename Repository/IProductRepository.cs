using System.Collections.Generic;
namespace ConsoleToWebAPI
{
    public interface IProductRepository
    {
        int AddProduct (ProductModel product);
        List<ProductModel> GetAllProducts ();
    }
}