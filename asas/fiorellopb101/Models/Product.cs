namespace fiorellopb101.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
