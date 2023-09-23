using ErpStorageApi.Entities;

namespace ErpStorageApi.Data.Interfaces
{
    public interface ICategoriesRepository
    {
        Task Add(Category category);
        Task Delete(Category category);
        Task Update(Category category);
        Task<Category> GetById(int id);
        Task<List<Category>> GetAll();
    }
}
