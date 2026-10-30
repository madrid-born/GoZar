using GoZar.Api.Domain.Curriculum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Curriculum;

public sealed class LearningGoalConfiguration : IEntityTypeConfiguration<LearningGoal>
{
    public void Configure(EntityTypeBuilder<LearningGoal> builder)
    {
        builder.ToTable("LearningGoal", "Curriculum");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Code).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Title).HasMaxLength(200).IsRequired();
        builder.HasIndex(x => x.Code).IsUnique();
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
