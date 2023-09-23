using ErpStorageApi.Entities;

namespace ErpStorageApi.Data.Interfaces
{
    public interface ICategoryRepository
    {
        Task Add(Category category);
        Task Delete(Category category);
        Task Update(Category category);
        Task<Category> GetById(int id);
        Task<List<Category>> GetAll();
    }
}
