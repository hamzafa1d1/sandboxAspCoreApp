using challengeApp.Data;
using challengeApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace TestProject2.DatabaseFixture;

public class DatabaseFixture : IDisposable
{
    public AppDbContext Context { get; private set; }

    public DatabaseFixture()
    {
        var inMemoryOptions = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;
        Context = new AppDbContext(inMemoryOptions);
        SeedData();
        Context.SaveChanges();
    }

    private void SeedData()
    {
        Context.CardHolders.AddRange(
            new CardHolder() { Id = Guid.NewGuid(), Email = "test@gmail.com"},
            new CardHolder() { Id = Guid.NewGuid(), Email = "test2@gmail.com"}
            );
    }
    public void Dispose()
    {
        Context.Dispose();
    }
}