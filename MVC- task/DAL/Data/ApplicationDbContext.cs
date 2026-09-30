using DAL.Data.Entities;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVC__task.Data
{
        public class ApplicationDbContext : IdentityDbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            
            }

            public DbSet<Car> Cars { get; set; }

            public DbSet<Client> Clients { get; set; }

            public DbSet<Purchase> Purchases { get; set;}
        }
    }
