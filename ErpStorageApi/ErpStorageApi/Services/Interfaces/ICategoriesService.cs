using ErpStorageApi.Entities;

namespace ErpStorageApi.Services.Interfaces
{
    public interface ICategoriesService
    {
        Task AddCategory(Category category);
        Task DeleteCategory(Category category);
        Task UpdateCategory(Category category);
        Task<Category> GetCategoryById(int id);
        Task<List<Category>> GetAllCategories();
    }
}
