namespace ErpStorageApi.Dtos.Product
{
    public class CreateProductRequestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
