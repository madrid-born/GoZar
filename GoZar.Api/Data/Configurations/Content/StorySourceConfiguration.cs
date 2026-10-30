using GoZar.Api.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Content;

public sealed class StorySourceConfiguration : IEntityTypeConfiguration<StorySource>
{
    public void Configure(EntityTypeBuilder<StorySource> builder)
    {
        builder.ToTable("StorySource", "Content");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.HasIndex(x => new { x.StoryId, x.ContentSourceId }).IsUnique();
        builder.HasOne<Story>().WithMany().HasForeignKey(x => x.StoryId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<ContentSource>().WithMany().HasForeignKey(x => x.ContentSourceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
