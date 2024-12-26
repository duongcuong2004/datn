using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Size
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "Tên kích thước không được dài quá 5 ký tự.")]
        public string SizeName { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
