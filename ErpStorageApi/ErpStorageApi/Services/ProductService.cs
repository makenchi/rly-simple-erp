using ErpStorageApi.Data.Interfaces;
using ErpStorageApi.Entities;
using ErpStorageApi.Services.Interfaces;

namespace ErpStorageApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productsRepository;
        public ProductService(IProductRepository productsRepository)
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
            return product;
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
