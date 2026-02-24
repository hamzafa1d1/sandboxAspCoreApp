using challengeApp.Data;
using challengeApp.Entities;

namespace challengeApp.DataAccess;

public class CardHolderRepo : ICardHolderRepo
{
    private readonly AppDbContext _context;

    public CardHolderRepo(AppDbContext context)
    {
        _context = context;
    }
    public CardHolder GetCardHolder(Guid Id)
    {
        throw new NotImplementedException();
    }
}