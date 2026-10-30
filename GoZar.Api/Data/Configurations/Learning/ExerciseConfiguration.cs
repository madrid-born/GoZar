using GoZar.Api.Domain.Learning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Learning;

public sealed class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        builder.ToTable("Exercise", "Learning");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.ExerciseType).HasMaxLength(200).IsRequired();
        builder.Property(x => x.SkillCode).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Prompt).HasMaxLength(200).IsRequired();
        builder.Property(x => x.PublicContentJson).HasColumnType("nvarchar(max)").IsRequired();
        builder.Property(x => x.CorrectAnswerJson).HasColumnType("nvarchar(max)").IsRequired();
        builder.Property(x => x.Explanation).HasColumnType("nvarchar(max)");
        builder.HasIndex(x => x.SessionItemId).IsUnique();
        builder.HasOne<SessionItem>().WithMany().HasForeignKey(x => x.SessionItemId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<LearningTarget>().WithMany().HasForeignKey(x => x.LearningTargetId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
