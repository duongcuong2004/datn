using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Voucher
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Mã không được dài quá 50 ký tự.")]
        public string Code { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Phần trăm giảm giá phải từ 0 đến 100.")]
        public int DiscountPercentage { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
