using challengeApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace challengeApp.Data;

public class PaymentCardEntityConfiguration : IEntityTypeConfiguration<PaymentCardEntity>
{
    public void Configure(EntityTypeBuilder<PaymentCardEntity> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.CardName);

        builder.HasOne(u => u.CardHolder)
            .WithMany(u => u.Cards)
            .HasForeignKey(u => u.CardHolderId);
    }
}