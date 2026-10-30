using GoZar.Api.Domain.Learning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Learning;

public sealed class SessionItemConfiguration : IEntityTypeConfiguration<SessionItem>
{
    public void Configure(EntityTypeBuilder<SessionItem> builder)
    {
        builder.ToTable("SessionItem", "Learning");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.ItemKind).HasMaxLength(200).IsRequired();
        builder.HasIndex(x => new { x.LearningSessionId, x.Position }).IsUnique();
        builder.HasOne<GoZar.Api.Domain.Learning.LearningSession>().WithMany().HasForeignKey(x => x.LearningSessionId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Curriculum.Lesson>().WithMany().HasForeignKey(x => x.LessonId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Learning.LearningTarget>().WithMany().HasForeignKey(x => x.LearningTargetId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
