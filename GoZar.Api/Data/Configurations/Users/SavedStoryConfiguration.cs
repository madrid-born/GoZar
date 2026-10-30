using GoZar.Api.Domain.Content;
using GoZar.Api.Domain.Users;
using GoZar.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Users;

public sealed class SavedStoryConfiguration : IEntityTypeConfiguration<SavedStory>
{
    public void Configure(EntityTypeBuilder<SavedStory> builder)
    {
        builder.ToTable("SavedStory", "Profiles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
        builder.HasIndex(x => new { x.UserId, x.StoryId }).IsUnique();
        builder.HasOne<ApplicationUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<Story>().WithMany().HasForeignKey(x => x.StoryId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
