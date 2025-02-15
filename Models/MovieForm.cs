using System.ComponentModel.DataAnnotations;

namespace mission6Assignment.Models
{
    public class MovieForm
    {
        [Key]
        public int formID { get; set; }
        [Required]
        public string movieCat {  get; set; }
        public string movieTitle { get; set; }
        public int movieYear { get; set; }
        public string movieDirector {  get; set; }
        public string movieRating { get; set; }
        public bool isEdited { get; set; }
        public string lentTo { get; set; }
        public string Notes { get; set; }

    }
}
