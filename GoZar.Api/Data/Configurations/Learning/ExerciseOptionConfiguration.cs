using GoZar.Api.Domain.Learning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Learning;

public sealed class ExerciseOptionConfiguration : IEntityTypeConfiguration<ExerciseOption>
{
    public void Configure(EntityTypeBuilder<ExerciseOption> builder)
    {
        builder.ToTable("ExerciseOption", "Learning");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Text).HasColumnType("nvarchar(max)").IsRequired();
        builder.HasIndex(x => new { x.ExerciseId, x.Position }).IsUnique();
        builder.HasOne<Exercise>().WithMany().HasForeignKey(x => x.ExerciseId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
