using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Geography;

public sealed class PlaceRelationship : DomainEntity
{
    public Guid FromPlaceId { get; set; }
    public Guid ToPlaceId { get; set; }
    public string RelationshipType { get; set; } = string.Empty;
    public string? Explanation { get; set; } = null;
    public bool IsReviewed { get; set; } = false;
}
