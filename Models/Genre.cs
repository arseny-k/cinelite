namespace CineLite.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
