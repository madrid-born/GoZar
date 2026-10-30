using GoZar.Api.Domain.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoZar.Api.Data.Configurations.Content;

public sealed class ContentSourceConfiguration : IEntityTypeConfiguration<ContentSource>
{
    public void Configure(EntityTypeBuilder<ContentSource> builder)
    {
        builder.ToTable("ContentSource", "Content");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Title).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Url).HasMaxLength(2048).IsRequired();
        builder.Property(x => x.Attribution).HasMaxLength(200);
        builder.Property(x => x.License).HasMaxLength(200);
        // TODO : Review lengths, uniqueness, same-city relationships and delete policies before generating migrations.
    }
}
