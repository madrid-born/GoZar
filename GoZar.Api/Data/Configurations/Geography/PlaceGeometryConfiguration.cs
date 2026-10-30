using GoZar.Api.Domain.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Geography;

public sealed class PlaceGeometryConfiguration : IEntityTypeConfiguration<PlaceGeometry>
{
    public void Configure(EntityTypeBuilder<PlaceGeometry> builder)
    {
        builder.ToTable("PlaceGeometry", "Catalog");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.GeometryType).HasMaxLength(200).IsRequired();
        builder.Property(x => x.GeoJson).HasColumnType("nvarchar(max)").IsRequired();
        builder.Property(x => x.SourceAttribution).HasColumnType("nvarchar(max)");
        builder.HasIndex(x => new { x.PlaceId, x.Version }).IsUnique();
        builder.HasOne<Place>().WithMany().HasForeignKey(x => x.PlaceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
