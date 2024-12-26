using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class ProductDetail
    {
        public Guid Id { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        public Guid SizeId { get; set; }

        [Required]
        public Guid ColorId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn hoặc bằng 1.")]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Mã sản phẩm không được dài quá 10 ký tự.")]
        public string ProductCode { get; set; }

        public Product Product { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
    }
}
