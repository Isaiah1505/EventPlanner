﻿using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class Category
    {
        // PK
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }


        public string? Colour { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }
    }
}