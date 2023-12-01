using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BookInfo
    {
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? Pub_Date { get; set; }
        public string? Genre { get; set; }
    }
}