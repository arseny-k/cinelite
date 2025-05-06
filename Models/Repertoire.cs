namespace CineLite.Models
{
    public class Repertoire
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal TicketPrice { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;

    }
}
