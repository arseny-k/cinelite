namespace CineLite.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Gender { get; set; }
        public int Age { get; set; }
        public required string Address { get; set; }
        public required string Phone { get; set; }
        public required string PassportData { get; set; }

        public int PositionId { get; set; }
        public Position? Position { get; set; }
    }
}
