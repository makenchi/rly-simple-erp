using ErpStorageApi.Entities;

namespace ErpStorageApi.Data.Interfaces
{
    public interface IProductsRepository
    {
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(Product product);
        Task<Product> GetById(int id);
        Task<List<Product>> GetByCategory(int categoryId);
        Task<List<Product>> GetAll();
    }
}
