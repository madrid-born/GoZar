using GoZar.Api.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Content;

public sealed class PlaceFactSourceConfiguration : IEntityTypeConfiguration<PlaceFactSource>
{
    public void Configure(EntityTypeBuilder<PlaceFactSource> builder)
    {
        builder.ToTable("PlaceFactSource", "Content");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.HasIndex(x => new { x.PlaceFactId, x.ContentSourceId }).IsUnique();
        builder.HasOne<GoZar.Api.Domain.Content.PlaceFact>().WithMany().HasForeignKey(x => x.PlaceFactId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Content.ContentSource>().WithMany().HasForeignKey(x => x.ContentSourceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
