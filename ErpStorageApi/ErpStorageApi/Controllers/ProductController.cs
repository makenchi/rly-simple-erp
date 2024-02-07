using ErpStorageApi.Dtos.Product;
using ErpStorageApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpStorageApi.Controllers
{
    [Route("api/v1/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<ActionResult<CreateProductResponseDto>> CreateProduct(CreateProductRequestDto request)
        {
            CreateProductResponseDto response = new CreateProductResponseDto();
            try
            {
                var category = await _categoryService.GetCategoryById(request.CategoryId);
                if (category == null)
                {
                    response.Code = 500;
                    response.Message = "Product must have a valid category";
                    return BadRequest(response);
                }

                ProductDto newProduct = new ProductDto() 
                {
                    Name = request.Name,
                    Description = request.Description,
                    ProductId = request.ProductId,
                    CreatedAt = DateTime.Now,
                    Quantity = request.Quantity,
                    CategoryId = request.CategoryId
                };

                await _productService.CreateProduct(newProduct);

                response.Code = 200;
                response.Message = "Product added sucessifully";

                return Ok(response);
            }
            catch (Exception ex)
            {
                response.Code = ex.HResult;
                response.Message = ex.Message;
            }

            return BadRequest(response);
        }
    }
}
