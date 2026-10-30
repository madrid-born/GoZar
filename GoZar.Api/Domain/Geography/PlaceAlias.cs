using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Geography;

public sealed class PlaceAlias : DomainEntity
{
    public Guid PlaceId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LanguageCode { get; set; } = "fa";
    public string AliasType { get; set; } = "common";
}
