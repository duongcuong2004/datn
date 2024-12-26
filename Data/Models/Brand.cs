using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Brand
    {
        public Guid Id { get; set; } 

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }

        [StringLength(500)]
        public string? Logo { get; set; }
    }
}
