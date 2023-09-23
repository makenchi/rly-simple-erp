using ErpStorageApi.Data.Interfaces;
using ErpStorageApi.Entities;
using ErpStorageApi.Services.Interfaces;

namespace ErpStorageApi.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public async Task AddProduct(Product product)
        {
            await _productsRepository.Add(product);
        }

        public async Task DeleteProduct(Product product)
        {
            await _productsRepository.Delete(product);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var products = await _productsRepository.GetAll();
            return products;
        }

        public async Task<Product> GetProductById(int id)
        {
            var product = await _productsRepository.GetById(id);
        }

        public async Task<List<Product>> GetProductsByCategory(int categoryId)
        {
            var products = await GetProductsByCategory(categoryId);
            return products;
        }

        public async Task UpdateProduct(Product product)
        {
            await UpdateProduct(product);
        }
    }
}
