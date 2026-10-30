using GoZar.Api.Domain.Curriculum;
using GoZar.Api.Domain.Geography;
using GoZar.Api.Domain.Learning;
using GoZar.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Learning;

public sealed class LearningSessionConfiguration : IEntityTypeConfiguration<LearningSession>
{
    public void Configure(EntityTypeBuilder<LearningSession> builder)
    {
        builder.ToTable("LearningSession", "Learning");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
        builder.Property(x => x.SessionKind).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Status).HasMaxLength(200).IsRequired();
        builder.HasIndex(x => new { x.UserId, x.ClientRequestId }).IsUnique();
        builder.HasOne<ApplicationUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<City>().WithMany().HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne<Chapter>().WithMany().HasForeignKey(x => x.ChapterId).OnDelete(DeleteBehavior.Restrict);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
