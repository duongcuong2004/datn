using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Review
    {
        public Guid Id { get; set; } 

        [Required]
        public Guid ProductId { get; set; } 

        [ForeignKey("ProductId")]
        public Product Product { get; set; } 

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; } 

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; } 

        public string? Comment { get; set; } 

        public DateTime CreateAt { get; set; }
    }
}
