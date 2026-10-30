using GoZar.Api.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Content;

public sealed class ContentPackConfiguration : IEntityTypeConfiguration<ContentPack>
{
    public void Configure(EntityTypeBuilder<ContentPack> builder)
    {
        builder.ToTable("ContentPack", "Content");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Status).HasMaxLength(200).IsRequired();
        builder.Property(x => x.StorageKey).HasMaxLength(1000);
        builder.Property(x => x.Sha256).HasMaxLength(200);
        builder.HasIndex(x => new { x.CityId, x.Version }).IsUnique();
        builder.HasOne<GoZar.Api.Domain.Geography.City>().WithMany().HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
