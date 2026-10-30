using GoZar.Api.Domain.Curriculum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Curriculum;

public sealed class LessonPlaceConfiguration : IEntityTypeConfiguration<LessonPlace>
{
    public void Configure(EntityTypeBuilder<LessonPlace> builder)
    {
        builder.ToTable("LessonPlace", "Curriculum");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.HasIndex(x => new { x.LessonId, x.PlaceId }).IsUnique();
        builder.HasOne<GoZar.Api.Domain.Curriculum.Lesson>().WithMany().HasForeignKey(x => x.LessonId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Geography.Place>().WithMany().HasForeignKey(x => x.PlaceId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
