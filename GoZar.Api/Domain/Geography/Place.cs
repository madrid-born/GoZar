using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Geography;

public sealed class Place : DomainEntity
{
    public Guid CityId { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string NameFa { get; set; } = string.Empty;
    public string? NameEn { get; set; } = null;
    public string PlaceType { get; set; } = "other";
    public int Importance { get; set; } = 0;
    public decimal Latitude { get; set; } = 0;
    public decimal Longitude { get; set; } = 0;
    public bool IsPublished { get; set; } = false;
    public string? ExternalId { get; set; } = null;
}
