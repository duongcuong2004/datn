using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class AboutUs
    {
        public Guid Id { get; set; } 

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; } 

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
