using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Color
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Tên màu không được dài quá 20 ký tự.")]
        public string ColorName { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
