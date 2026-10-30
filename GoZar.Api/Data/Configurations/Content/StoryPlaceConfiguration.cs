using GoZar.Api.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Content;

public sealed class StoryPlaceConfiguration : IEntityTypeConfiguration<StoryPlace>
{
    public void Configure(EntityTypeBuilder<StoryPlace> builder)
    {
        builder.ToTable("StoryPlace", "Content");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.HasIndex(x => new { x.StoryId, x.PlaceId }).IsUnique();
        builder.HasOne<GoZar.Api.Domain.Content.Story>().WithMany().HasForeignKey(x => x.StoryId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Geography.Place>().WithMany().HasForeignKey(x => x.PlaceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
