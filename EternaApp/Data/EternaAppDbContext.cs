using EternaApp.Entities;
using EternaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Data
{
    public class EternaAppDbContext : DbContext
    {
        public EternaAppDbContext(DbContextOptions options):base(options)
        {
            
        }
       public DbSet<Slider> Sliders { get; set; }
       public DbSet<Category> Categories { get; set; }
       public DbSet<Portfolio> Portfolios { get; set; }
       public DbSet<PortfolioImages> PortfolioImages { get; set; }
       public DbSet<Client> Clients { get; set; }
       public DbSet<ClientLogoImages> ClientLogoImages { get; set; }
        


    }
}
