using ErpStorageApi.Dtos;
using ErpStorageApi.Entities;
using ErpStorageApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpStorageApi.Controllers
{
    [Route("category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<ActionResult<AddCategoryResponseDto>> AddCategory(AddCategoryRequestDto request)
        {
            AddCategoryResponseDto response = new AddCategoryResponseDto();
            try
            {
                Category newCategory = new Category()
                {
                    Name = request.Name
                };

                await _categoryService.AddCategory(newCategory);

                response.Code = 200;
                response.Message = "Category added sucessifully";

                return Ok(response);
            }
            catch (Exception ex)
            {
                response.Code = ex.HResult;
                response.Message = ex.Message;
            }

            return BadRequest(response);
        }

        [HttpPut]
        public async Task<ActionResult<UpdateCategoryResponseDto>> UpdateCategory(UpdateCategoryRequestDto request)
        {
            UpdateCategoryResponseDto response = new UpdateCategoryResponseDto();
            try
            {
                var category = await _categoryService.GetCategoryById(request.Id);
                if (category == null)
                {
                    response.Code = 404;
                    response.Message = "Category not found";

                    return NotFound(response);
                }

                category.Name = request.Name;
                await _categoryService.UpdateCategory(category);

                response.Code = 200;
                response.Message = "Category updated";
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.Code = ex.HResult;
                response.Message = ex.Message;
            }

            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<ActionResult<DeleteCategoryResponseDto>> DeleteCategory(DeleteCategoryRequestDto request)
        {
            DeleteCategoryResponseDto response = new DeleteCategoryResponseDto();
            try
            {
                var category = await _categoryService.GetCategoryById(request.Id);
                if (category == null)
                {
                    response.Code = 404;
                    response.Message = "Category not found";

                    return NotFound(response);
                }

                await _categoryService.DeleteCategory(category);

                response.Code = 200;
                response.Message = "Category deleted";
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
