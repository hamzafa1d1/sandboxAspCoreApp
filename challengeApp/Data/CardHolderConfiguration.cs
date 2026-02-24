using challengeApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace challengeApp.Data;

public class CardHolderConfiguration : IEntityTypeConfiguration<CardHolder>
{
    public void Configure(EntityTypeBuilder<CardHolder> builder)
    {
        builder.HasKey(u => u.Id);
    }
}