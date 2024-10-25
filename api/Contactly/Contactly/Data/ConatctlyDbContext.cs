using Contactly.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Contactly.Data
{
    public class ConatctlyDbContext : DbContext
    {
        public ConatctlyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
