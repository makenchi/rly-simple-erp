using ErpStorageApi.Data.Interfaces;
using ErpStorageApi.Dtos.Product;
using ErpStorageApi.Entities;
using ErpStorageApi.Services.Interfaces;

namespace ErpStorageApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productsRepository;
        private readonly ICategoryService _categoryService;
        public ProductService(IProductRepository productsRepository, ICategoryService categoryService)
        {
            _productsRepository = productsRepository;
            _categoryService = categoryService;
        }

        public async Task AddProduct(Product product)
        {
            await _productsRepository.Add(product);
        }

        public async Task CreateProduct(ProductDto product)
        {
            Product newProduct = new Product()
            {
                Name = product.Name,
                Description = product.Description,
                ProductId = product.ProductId,
                CreatedAt = (DateTime)product.CreatedAt,
                Quantity = (int)product.Quantity,
                CategoryId = (int)product.CategoryId
            };

            await AddProduct(newProduct);
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
