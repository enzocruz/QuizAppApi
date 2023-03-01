using System.ComponentModel.DataAnnotations;

namespace Repo.Models{
    public class Quiz {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        public string? Description { get; set; }


        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public bool IsActive { get; set; }
    }

}