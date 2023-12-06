using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieDB.Models
{
    public class MovieGenre
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //this was for auto-incrementing the PK
        public int MovieGenreId { get; set; }

        public int MovieId { get; set; }

        public Movie? Movie { get; set; }

        public int GenreId { get; set; }

        public Genre? Genre { get; set; }
    }

}