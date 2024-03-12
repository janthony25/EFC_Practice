using EFC_Practice.Models;
using Microsoft.EntityFrameworkCore;

namespace EFC_Practice.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
