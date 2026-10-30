using GoZar.Api.Domain.Learning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GoZar.Api.Data.Configurations.Learning;

public sealed class ScoreTransactionConfiguration : IEntityTypeConfiguration<ScoreTransaction>
{
    public void Configure(EntityTypeBuilder<ScoreTransaction> builder)
    {
        builder.ToTable("ScoreTransaction", "Learning");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
        builder.HasIndex(x => x.AnswerSubmissionId).IsUnique();
        builder.HasOne<GoZar.Api.Models.ApplicationUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<GoZar.Api.Domain.Learning.AnswerSubmission>().WithMany().HasForeignKey(x => x.AnswerSubmissionId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
