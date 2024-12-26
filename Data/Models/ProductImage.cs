using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class ProductImage
    {
        public Guid Id { get; set; }

        [Required]
        public string? Image { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
