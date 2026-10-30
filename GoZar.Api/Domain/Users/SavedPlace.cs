namespace GoZar.Api.Domain.Users;

public sealed class SavedPlace : DomainEntity
{
    public string UserId { get; set; } = string.Empty;
    public Guid PlaceId { get; set; }
}
