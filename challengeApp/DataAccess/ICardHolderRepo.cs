using challengeApp.Entities;

namespace challengeApp.DataAccess;

public interface ICardHolderRepo
{
    CardHolder GetCardHolder(Guid Id);
}