using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission6Assignment.Models
{
    public class Movies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        [Required(ErrorMessage = "Category is required")]
        public int? CategoryId { get; set; }
        public string Title { get; set; }
        [Range(1888,2026)]
        public int Year { get; set; }
        public string? Director {  get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public string CopiedToPlex { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? Notes { get; set; }

    }
}
