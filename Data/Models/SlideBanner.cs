using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class SlideBanner
    {
        public Guid Id { get; set; } 

        [Required]
        [StringLength(500)]
        public string? Image { get; set; }

        [StringLength(200)]
        public string? Title { get; set; } 

        [StringLength(500)]
        public string? Link { get; set; } 

        public bool IsActive { get; set; } 

        public DateTime CreateAt { get; set; }
    }
}
