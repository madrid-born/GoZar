using System.ComponentModel.DataAnnotations;

namespace GoZar.Api.Features.Catalog.Contracts;

public sealed record MapViewportQuery(Guid CityId,
    [Range(-180, 180)] decimal West, [Range(-90, 90)] decimal South,
    [Range(-180, 180)] decimal East, [Range(-90, 90)] decimal North,
    string Layer = "learning");
// TODO : Bound viewport extent, geometry detail and response size; validate south < north and west < east for supported cities.
