using GoZar.Api.Domain.Curriculum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Curriculum;

public sealed class ChapterPrerequisiteConfiguration : IEntityTypeConfiguration<ChapterPrerequisite>
{
    public void Configure(EntityTypeBuilder<ChapterPrerequisite> builder)
    {
        builder.ToTable("ChapterPrerequisite", "Curriculum");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.HasIndex(x => new { x.ChapterId, x.RequiredChapterId }).IsUnique();
        builder.HasOne<Chapter>().WithMany().HasForeignKey(x => x.ChapterId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<Chapter>().WithMany().HasForeignKey(x => x.RequiredChapterId).OnDelete(DeleteBehavior.Restrict);
        builder.ToTable(t => t.HasCheckConstraint("CK_ChapterPrerequisite_NoSelf", "[ChapterId] <> [RequiredChapterId]"));
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
