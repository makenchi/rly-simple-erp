namespace ErpStorageApi.Dtos.Category
{
    public class GetCategoryByIdResponseDto : ResponseBaseDto
    {
        public CategoryDto? Category { get; set; }
    }
}
