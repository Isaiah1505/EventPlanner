using EventPlanner.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Category> Categories { get; 
            set;
        }

        public DbSet<Event> Events { get; 
            set; 
        }

        public DbSet<Calendar> Calendars { get; 
            set; 
        }
    }
}
