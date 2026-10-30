using GoZar.Api.Domain.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Geography;

public sealed class PlaceRelationshipConfiguration : IEntityTypeConfiguration<PlaceRelationship>
{
    public void Configure(EntityTypeBuilder<PlaceRelationship> builder)
    {
        builder.ToTable("PlaceRelationship", "Catalog");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.RelationshipType).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Explanation).HasColumnType("nvarchar(max)");
        builder.HasIndex(x => new { x.FromPlaceId, x.ToPlaceId, x.RelationshipType }).IsUnique();
        builder.HasOne<GoZar.Api.Domain.Geography.Place>().WithMany().HasForeignKey(x => x.FromPlaceId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Geography.Place>().WithMany().HasForeignKey(x => x.ToPlaceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
