using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Learning;

public sealed class LearningTarget : DomainEntity
{
    // TODO : Validate exactly one place/relationship target; add new target kinds only when exercises need them.
    public Guid? PlaceId { get; set; } = null;
    public Guid? PlaceRelationshipId { get; set; } = null;
    public string TargetKind { get; set; } = "place";
}
