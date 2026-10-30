using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Content;

public sealed class ContentPack : DomainEntity
{
    public Guid CityId { get; set; }
    public int Version { get; set; } = 1;
    public string Status { get; set; } = "draft";
    public string? StorageKey { get; set; } = null;
    public string? Sha256 { get; set; } = null;
    public long SizeBytes { get; set; } = 0;
}
