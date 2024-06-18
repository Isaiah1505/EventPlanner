using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class Calendar
    {
        // PK
       [Key] public int CalenderId { get; set; }

        public string? DayOfWeek { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }
    }
}
