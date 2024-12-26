using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class News
    {
        public Guid Id { get; set; } 
        [Required]
        [StringLength(200)]
        public string Title { get; set; } 

        [Required]
        public string Content { get; set; } 

        [Required]
        [StringLength(100)]
        public string Author { get; set; } 

        public DateTime PublishDate { get; set; }

        [StringLength(500)]
        public string? Image { get; set; }
    }
}
