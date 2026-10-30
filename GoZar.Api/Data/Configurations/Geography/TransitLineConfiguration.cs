using GoZar.Api.Domain.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Geography;

public sealed class TransitLineConfiguration : IEntityTypeConfiguration<TransitLine>
{
    public void Configure(EntityTypeBuilder<TransitLine> builder)
    {
        builder.ToTable("TransitLine", "Catalog");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
        builder.Property(x => x.TransportMode).HasMaxLength(200).IsRequired();
        builder.Property(x => x.ColorHex).HasMaxLength(200);
        builder.HasOne<GoZar.Api.Domain.Geography.City>().WithMany().HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
