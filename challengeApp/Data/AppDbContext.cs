using challengeApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace challengeApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    public DbSet<PaymentCardEntity> PaymentCardEntities { get; set; }
    public DbSet<CardHolder> CardHolders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}