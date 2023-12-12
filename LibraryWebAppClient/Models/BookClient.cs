using System.ComponentModel.DataAnnotations;

namespace LibraryWebAppClient.Models
{
    public class BookClient
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        [Range(0, 5)]
        public double Rating { get; set; }
        [Url]
        public string? CoverUrl { get; set; }
    }
}
