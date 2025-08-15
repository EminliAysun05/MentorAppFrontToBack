using MentorAppFrontToBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentorAppFrontToBack.Data;

public class MentorAppDb : DbContext
{
    public MentorAppDb(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Hero> Heroes { get; set; }
    public DbSet<WhyUs> WhyUs { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Packet> Packets { get; set; }
    public DbSet<Pricing> Pricings { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PricingPacket>().
            HasKey(pp => new { pp.PricingId, pp.PacketId });
        base.OnModelCreating(modelBuilder);
    }
}
