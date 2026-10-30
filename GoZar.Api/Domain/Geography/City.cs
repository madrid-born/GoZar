namespace GoZar.Api.Domain.Geography;

public sealed class City : DomainEntity
{
    // TODO : Confirm timezone identifiers and defaults for cross-platform clients; avoid hard-coded UTC offsets.
    public string Slug { get; set; } = string.Empty;
    public string NameFa { get; set; } = string.Empty;
    public string? NameEn { get; set; } = null;
    public string TimeZoneId { get; set; } = "Asia/Tehran";
    public decimal Latitude { get; set; } = 0;
    public decimal Longitude { get; set; } = 0;
    public bool IsPublished { get; set; } = false;
}
