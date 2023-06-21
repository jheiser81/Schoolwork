using System.ComponentModel.DataAnnotations;

namespace MovieDB.Models
{
    public class Movie
    {
        [Key] //This indicates the ID should be treated as a primary key in the database
        public int MovieId { get; set; }

        [Required] //this indicates the field is required
        [StringLength(100)] //this indicates the maximum length of the field
        public string? Title { get; set; }

        [Required]
        [StringLength(100)]
        public string? ReleaseDate { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
    }
}