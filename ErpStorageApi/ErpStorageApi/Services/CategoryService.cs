using ErpStorageApi.Data.Interfaces;
using ErpStorageApi.Entities;
using ErpStorageApi.Services.Interfaces;

namespace ErpStorageApi.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoriesRepository;
        public CategoryService(ICategoryRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public async Task AddCategory(Category category)
        {
            await _categoriesRepository.Add(category);
        }

        public async Task DeleteCategory(Category category)
        {
            await _categoriesRepository.Delete(category);
        }

        public async Task<List<Category>> GetAllCategories()
        {
            var categories = await _categoriesRepository.GetAll();
            return categories;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var category = await _categoriesRepository.GetById(id);
            return category;
        }

        public async Task UpdateCategory(Category category)
        {
            await _categoriesRepository.Update(category);
        }
    }
}
