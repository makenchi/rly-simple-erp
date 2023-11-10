namespace ErpStorageApi.Dtos
{
    public class GetCategoryByIdResponseDto : ResponseBaseDto
    {
        public CategoryDto? Category { get; set; }
    }
}
