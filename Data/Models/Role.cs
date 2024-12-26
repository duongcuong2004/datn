using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Role
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Tên vai trò không được dài quá 50 ký tự.")]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
