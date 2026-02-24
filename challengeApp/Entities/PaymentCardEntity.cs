namespace challengeApp.Entities;

public class PaymentCardEntity
{
    public Guid Id { get; set; }
    public string CardName { get; set; }
    
    public Guid CardHolderId { get; set; }
    
    public CardHolder CardHolder { get; set; }
}