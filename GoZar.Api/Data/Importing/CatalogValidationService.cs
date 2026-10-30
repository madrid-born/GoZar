using GoZar.Api.Features.Administration.Contracts;

namespace GoZar.Api.Data.Importing;

public sealed class CatalogValidationService
{
    public Task<ValidationReportResponse> ValidateCityAsync(Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Check geometry ranges, same-city relationships, aliases, prerequisite cycles, sources and ambiguous exercise candidates.
        throw new NotImplementedException();
    }
}
