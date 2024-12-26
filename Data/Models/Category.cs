using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Tên danh mục không được dài quá 100 ký tự.")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
