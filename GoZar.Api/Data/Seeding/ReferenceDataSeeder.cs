namespace GoZar.Api.Data.Seeding;

public sealed class ReferenceDataSeeder
{
    public Task SeedAsync(CancellationToken cancellationToken = default)
    {
        // TODO : Add idempotent, explicitly invoked reference data (goal codes, cities); never auto-seed fabricated content.
        throw new NotImplementedException();
    }
}
