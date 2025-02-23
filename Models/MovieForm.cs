using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission6Assignment.Models
{
    public class MovieForm
    {
        [Key]
        [Required]
        public int formID { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string movieTitle { get; set; }
        public int movieYear { get; set; }
        public string movieDirector {  get; set; }
        public string movieRating { get; set; }
        public bool? isEdited { get; set; }
        public string? lentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? Notes { get; set; }

    }
}
