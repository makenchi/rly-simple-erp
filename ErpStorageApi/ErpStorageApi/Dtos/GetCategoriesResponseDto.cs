namespace ErpStorageApi.Dtos
{
    public class GetCategoriesResponseDto : ResponseBaseDto
    {
        public List<CategoryDto>? Categories { get; set; }
    }
}
