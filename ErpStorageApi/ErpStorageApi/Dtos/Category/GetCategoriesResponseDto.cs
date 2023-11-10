namespace ErpStorageApi.Dtos.Category
{
    public class GetCategoriesResponseDto : ResponseBaseDto
    {
        public List<CategoryDto>? Categories { get; set; }
    }
}
