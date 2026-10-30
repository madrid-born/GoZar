using GoZar.Api.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Content;

public sealed class ContentPackAssetConfiguration : IEntityTypeConfiguration<ContentPackAsset>
{
    public void Configure(EntityTypeBuilder<ContentPackAsset> builder)
    {
        builder.ToTable("ContentPackAsset", "Content");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.RelativePath).HasMaxLength(200).IsRequired();
        builder.Property(x => x.StorageKey).HasMaxLength(1000).IsRequired();
        builder.Property(x => x.Sha256).HasMaxLength(200).IsRequired();
        builder.HasIndex(x => new { x.ContentPackId, x.RelativePath }).IsUnique();
        builder.HasOne<ContentPack>().WithMany().HasForeignKey(x => x.ContentPackId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
