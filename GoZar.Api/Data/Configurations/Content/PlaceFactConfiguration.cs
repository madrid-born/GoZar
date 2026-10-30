using GoZar.Api.Domain.Content;
using GoZar.Api.Domain.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Content;

public sealed class PlaceFactConfiguration : IEntityTypeConfiguration<PlaceFact>
{
    public void Configure(EntityTypeBuilder<PlaceFact> builder)
    {
        builder.ToTable("PlaceFact", "Content");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Text).HasColumnType("nvarchar(max)").IsRequired();
        builder.HasOne<Place>().WithMany().HasForeignKey(x => x.PlaceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
