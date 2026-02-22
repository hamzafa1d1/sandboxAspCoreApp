using Microsoft.EntityFrameworkCore;

namespace challengeApp.DbConnectionSetup;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    // define your entites here 

}