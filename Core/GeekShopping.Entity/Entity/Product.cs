using Dapper.Contrib.Extensions;

namespace GeekShopping.Entity
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public long ID { get; set; }
        public Guid rowguid { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? Observation { get; set; }
        public string? Category { get; set; }
        public string? ImageURL { get; set; }
    }
}
