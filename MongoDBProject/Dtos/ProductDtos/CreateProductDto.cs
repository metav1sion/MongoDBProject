namespace MongoDBProject.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Stock { get; set; }
    }
}
