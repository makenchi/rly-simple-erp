using ErpStorageApi.Dtos.Product;
using ErpStorageApi.Entities;

namespace ErpStorageApi.Services.Interfaces
{
    public interface IProductService
    {
        Task AddProduct(Product product);
        Task CreateProduct(ProductDto product);
        Task DeleteProduct(Product product);
        Task UpdateProduct(Product product);
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(int categoryId);
    }
}
