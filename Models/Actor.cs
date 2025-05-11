namespace CineLite.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string AgeRestrictions { get; set; }
        public required string Description { get; set; }
    }
}
