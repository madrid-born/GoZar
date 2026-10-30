using GoZar.Api.Domain.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Geography;

public sealed class StationLineConfiguration : IEntityTypeConfiguration<StationLine>
{
    public void Configure(EntityTypeBuilder<StationLine> builder)
    {
        builder.ToTable("StationLine", "Catalog");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.HasIndex(x => new { x.TransitLineId, x.StationPlaceId }).IsUnique();
        builder.HasIndex(x => new { x.TransitLineId, x.Position }).IsUnique();
        builder.HasOne<GoZar.Api.Domain.Geography.Place>().WithMany().HasForeignKey(x => x.StationPlaceId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Geography.TransitLine>().WithMany().HasForeignKey(x => x.TransitLineId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
