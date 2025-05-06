namespace CineLite.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public required string SeatNumber { get; set; }
        public bool IsBooked { get; set; }

        public int RepertoireId { get; set; }
        public Repertoire Repertoire { get; set; } = null!;

        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
