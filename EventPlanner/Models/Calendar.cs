namespace EventPlanner.Models
{
    public class Calendar
    {
        // PK
        public int Id { get; set; }

        public string? DayName { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }
    }
}
