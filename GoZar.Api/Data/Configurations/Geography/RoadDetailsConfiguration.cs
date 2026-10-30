using GoZar.Api.Domain.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Geography;

public sealed class RoadDetailsConfiguration : IEntityTypeConfiguration<RoadDetails>
{
    public void Configure(EntityTypeBuilder<RoadDetails> builder)
    {
        builder.ToTable("RoadDetails", "Catalog");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.RoadClass).HasMaxLength(200).IsRequired();
        builder.HasIndex(x => x.PlaceId).IsUnique();
        builder.HasOne<Place>().WithMany().HasForeignKey(x => x.PlaceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
