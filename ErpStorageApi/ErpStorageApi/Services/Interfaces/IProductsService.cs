using ErpStorageApi.Entities;

namespace ErpStorageApi.Services.Interfaces
{
    public interface IProductsService
    {
        Task AddProduct(Product product);
        Task DeleteProduct(Product product);
        Task UpdateProduct(Product product);
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(int categoryId);
    }
}
