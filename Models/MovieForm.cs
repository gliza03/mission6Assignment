using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission6Assignment.Models
{
    public class MovieForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int formID { get; set; }

        [ForeignKey("CategoryId")]
        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }
        public string movieTitle { get; set; }
        [Range(1888,2026)]
        public int movieYear { get; set; }
        public string movieDirector {  get; set; }
        public string movieRating { get; set; }
        public bool? isEdited { get; set; }
        public string? lentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? Notes { get; set; }

    }
}
