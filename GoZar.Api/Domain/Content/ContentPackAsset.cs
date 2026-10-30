using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Content;

public sealed class ContentPackAsset : DomainEntity
{
    public Guid ContentPackId { get; set; }
    public string RelativePath { get; set; } = string.Empty;
    public string StorageKey { get; set; } = string.Empty;
    public string Sha256 { get; set; } = string.Empty;
    public long SizeBytes { get; set; } = 0;
}
