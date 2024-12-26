using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng số tiền phải lớn hơn hoặc bằng 0.")]
        public decimal TotalAmount { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Trạng thái không được dài quá 50 ký tự.")]
        public string Status { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
