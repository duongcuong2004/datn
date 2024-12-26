using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Tên đầy đủ không được dài quá 50 ký tự.")]
        public string FullName { get; set; }
        public string? Image { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
        [StringLength(150, ErrorMessage = "Email không được dài quá 150 ký tự.")]
        public string Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Số điện thoại phải dài 10 ký tự.")]
        public string Phone { get; set; }

        [StringLength(250, ErrorMessage = "Địa chỉ không được dài quá 250 ký tự.")]
        public string? Address { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự.")]
        public string Password { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        public Role Role { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> reviews { get; set; }
    }
}
