using GoZar.Api.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Users;

public sealed class UserDailyActivityConfiguration : IEntityTypeConfiguration<UserDailyActivity>
{
    public void Configure(EntityTypeBuilder<UserDailyActivity> builder)
    {
        builder.ToTable("UserDailyActivity", "Profiles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
        builder.Property(x => x.TimeZoneId).HasMaxLength(200).IsRequired();
        builder.HasIndex(x => new { x.UserId, x.LocalDate }).IsUnique();
        builder.HasOne<GoZar.Api.Models.ApplicationUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
