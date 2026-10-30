using GoZar.Api.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Users;

public sealed class UserLearningProfileConfiguration : IEntityTypeConfiguration<UserLearningProfile>
{
    public void Configure(EntityTypeBuilder<UserLearningProfile> builder)
    {
        builder.ToTable("UserLearningProfile", "Profiles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
        builder.HasIndex(x => x.UserId).IsUnique();
        builder.HasOne<GoZar.Api.Models.ApplicationUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Geography.City>().WithMany().HasForeignKey(x => x.SelectedCityId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
