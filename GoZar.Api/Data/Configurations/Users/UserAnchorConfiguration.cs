using GoZar.Api.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Users;

public sealed class UserAnchorConfiguration : IEntityTypeConfiguration<UserAnchor>
{
    public void Configure(EntityTypeBuilder<UserAnchor> builder)
    {
        builder.ToTable("UserAnchor", "Profiles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
        builder.Property(x => x.Label).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Latitude).HasPrecision(9, 6);
        builder.Property(x => x.Longitude).HasPrecision(9, 6);
        builder.HasOne<GoZar.Api.Models.ApplicationUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Geography.City>().WithMany().HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Geography.Place>().WithMany().HasForeignKey(x => x.PlaceId).OnDelete(DeleteBehavior.Restrict);
        builder.HasIndex(x => new { x.UserId, x.CityId });
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
