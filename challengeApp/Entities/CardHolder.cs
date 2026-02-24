namespace challengeApp.Entities;

public class CardHolder
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public ICollection<PaymentCardEntity> Cards { get; set; }
}