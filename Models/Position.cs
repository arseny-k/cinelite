namespace CineLite.Models
{
    public class Position
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public decimal Salary { get; set; }
        public required string Duties { get; set; }
        public required string Requirements { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
