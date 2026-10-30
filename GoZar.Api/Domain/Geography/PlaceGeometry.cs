using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Geography;

public sealed class PlaceGeometry : DomainEntity
{
    // TODO : GeoJSON text is provisional; consider SQL Server spatial types and segment-level geometry.
    public Guid PlaceId { get; set; }
    public string GeometryType { get; set; } = "Point";
    public string GeoJson { get; set; } = string.Empty;
    public int Version { get; set; } = 1;
    public string? SourceAttribution { get; set; } = null;
}
