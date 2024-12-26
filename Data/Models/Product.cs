using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(350, ErrorMessage = "Tên sản phẩm không được dài quá 350 ký tự.")]
        public string Title { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Giá sản phẩm phải lớn hơn hoặc bằng 0.")]
        public decimal Price { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Giảm giá không thể âm.")]
        public decimal? Discount { get; set; }

        public string? Image { get; set; }

        [StringLength(int.MaxValue, ErrorMessage = "Mô tả không được dài quá giới hạn.")]
        public string Description { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        [Range(0, 5, ErrorMessage = "Đánh giá trung bình phải từ 0 đến 5.")]
        public decimal AverageRating { get; set; }

        public int SalesCount { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<Review> reviews { get; set; }
    }
}
