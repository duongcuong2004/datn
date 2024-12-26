using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class OrderDetail
    {
        public Guid Id { get; set; }

        [Required]
        public Guid OrderId { get; set; }

        [Required]
        public Guid ProductDetailId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn hoặc bằng 1.")]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public Order Order { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
