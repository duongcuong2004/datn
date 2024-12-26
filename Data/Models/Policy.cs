using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Policy
    {
        public Guid Id { get; set; } 

        [Required]
        [StringLength(100)]
        public string PolicyType { get; set; } 

        [Required]
        public string Content { get; set; } 

        public DateTime CreateAt { get; set; } 

        public DateTime? UpdateAt { get; set; }
    }
}
