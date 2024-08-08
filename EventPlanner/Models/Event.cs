using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class Event
    {
        // PK
        public int EventId { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public string Date { get; set; }

        [MaxLength(100)]
        public string? Descrption { get; set; }

        public string Colour { get; set; }

        // FK
        [DisplayName("Category ID")]
        public int CategoryId { get; set; }

        // Parent reference

        public Category? Category { get; set; }


    }
}