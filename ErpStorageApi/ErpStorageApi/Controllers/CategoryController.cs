using ErpStorageApi.Dtos;
using ErpStorageApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpStorageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public Task<ActionResult<AddCategoryResponseDto>> AddCategory(AddCategoryRequestDto request)
        {
            AddCategoryResponseDto response = new AddCategoryResponseDto();
            try
            {

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
