namespace API.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public bool IsInStock { get; set; }
        public string ProductCategory { get; set; }
    }
}