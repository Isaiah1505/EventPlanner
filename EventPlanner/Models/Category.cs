using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class Category
    {
        // PK
        [DisplayName("Category ID")]

        public int CategoryId { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }


        public string? Colour { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }

        // child reference

        public List<Event>? Events { get; set; }
    }
}