using Microsoft.EntityFrameworkCore;
using Vega_Web.Models;

namespace Vega_Web.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) 
        : base(options)
        {
            
        }

        public DbSet<Make> Makes {get; set;}
        public DbSet<Model> Models {get; set;}
    }
}