using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Content;

public sealed class PlaceFact : DomainEntity
{
    public Guid PlaceId { get; set; }
    public string Text { get; set; } = string.Empty;
    public bool IsPublished { get; set; } = false;
}
