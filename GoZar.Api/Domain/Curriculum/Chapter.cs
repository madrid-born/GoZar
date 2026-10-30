namespace GoZar.Api.Domain.Curriculum;

public sealed class Chapter : DomainEntity
{
    public Guid CityId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; } = null;
    public int Position { get; set; } = 0;
    public bool IsPublished { get; set; } = false;
}
