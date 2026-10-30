using GoZar.Api.Domain.Learning;
using GoZar.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Learning;

public sealed class UserSkillProgressConfiguration : IEntityTypeConfiguration<UserSkillProgress>
{
    public void Configure(EntityTypeBuilder<UserSkillProgress> builder)
    {
        builder.ToTable("UserSkillProgress", "Learning");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
        builder.Property(x => x.SkillCode).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Status).HasMaxLength(200).IsRequired();
        builder.Property(x => x.SchedulerStateJson).HasColumnType("nvarchar(max)");
        builder.HasIndex(x => new { x.UserId, x.LearningTargetId, x.SkillCode }).IsUnique();
        builder.HasOne<ApplicationUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<LearningTarget>().WithMany().HasForeignKey(x => x.LearningTargetId).OnDelete(DeleteBehavior.Restrict);
        builder.HasIndex(x => new { x.UserId, x.NextReviewAtUtc });
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
