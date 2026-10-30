using GoZar.Api.Domain.Learning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Learning;

public sealed class LearningTargetConfiguration : IEntityTypeConfiguration<LearningTarget>
{
    public void Configure(EntityTypeBuilder<LearningTarget> builder)
    {
        builder.ToTable("LearningTarget", "Learning");
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.PlaceId).IsUnique();
        builder.HasIndex(x => x.PlaceRelationshipId).IsUnique();
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.TargetKind).HasMaxLength(200).IsRequired();
        builder.HasOne<GoZar.Api.Domain.Geography.Place>().WithMany().HasForeignKey(x => x.PlaceId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Geography.PlaceRelationship>().WithMany().HasForeignKey(x => x.PlaceRelationshipId).OnDelete(DeleteBehavior.Restrict);
        builder.ToTable(t => t.HasCheckConstraint("CK_LearningTarget_Reference", "([PlaceId] IS NOT NULL AND [PlaceRelationshipId] IS NULL) OR ([PlaceId] IS NULL AND [PlaceRelationshipId] IS NOT NULL)"));
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
