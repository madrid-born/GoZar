using GoZar.Api.Domain.Geography;
using GoZar.Api.Domain.Users;
using GoZar.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Users;

public sealed class SavedPlaceConfiguration : IEntityTypeConfiguration<SavedPlace>
{
    public void Configure(EntityTypeBuilder<SavedPlace> builder)
    {
        builder.ToTable("SavedPlace", "Profiles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
        builder.HasIndex(x => new { x.UserId, x.PlaceId }).IsUnique();
        builder.HasOne<ApplicationUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<Place>().WithMany().HasForeignKey(x => x.PlaceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
