using EternaApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Data
{
    public class EternaAppDbContext : DbContext
    {
        public EternaAppDbContext(DbContextOptions options):base(options)
        {
            
        }
       public DbSet<Slider> Sliders { get; set; }

    }
}
