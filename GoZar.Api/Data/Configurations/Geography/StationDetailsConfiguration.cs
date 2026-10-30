using GoZar.Api.Domain.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Geography;

public sealed class StationDetailsConfiguration : IEntityTypeConfiguration<StationDetails>
{
    public void Configure(EntityTypeBuilder<StationDetails> builder)
    {
        builder.ToTable("StationDetails", "Catalog");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.TransportMode).HasMaxLength(200).IsRequired();
        builder.Property(x => x.StationCode).HasMaxLength(200);
        builder.HasIndex(x => x.PlaceId).IsUnique();
        builder.HasOne<Place>().WithMany().HasForeignKey(x => x.PlaceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
