using GoZar.Api.Domain.Curriculum;
using GoZar.Api.Domain.Geography;
using GoZar.Api.Domain.Users;
using GoZar.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Users;

public sealed class UserLearningGoalConfiguration : IEntityTypeConfiguration<UserLearningGoal>
{
    public void Configure(EntityTypeBuilder<UserLearningGoal> builder)
    {
        builder.ToTable("UserLearningGoal", "Profiles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
        builder.HasIndex(x => new { x.UserId, x.CityId, x.LearningGoalId }).IsUnique();
        builder.HasOne<ApplicationUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<LearningGoal>().WithMany().HasForeignKey(x => x.LearningGoalId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<City>().WithMany().HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
