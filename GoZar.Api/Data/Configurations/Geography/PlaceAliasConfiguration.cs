using GoZar.Api.Domain.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Geography;

public sealed class PlaceAliasConfiguration : IEntityTypeConfiguration<PlaceAlias>
{
    public void Configure(EntityTypeBuilder<PlaceAlias> builder)
    {
        builder.ToTable("PlaceAlias", "Catalog");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
        builder.Property(x => x.LanguageCode).HasMaxLength(200).IsRequired();
        builder.Property(x => x.AliasType).HasMaxLength(200).IsRequired();
        builder.HasIndex(x => new { x.PlaceId, x.LanguageCode, x.Name }).IsUnique();
        builder.HasOne<Place>().WithMany().HasForeignKey(x => x.PlaceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
