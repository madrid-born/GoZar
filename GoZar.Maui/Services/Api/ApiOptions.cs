namespace GoZar.Maui.Services.Api;
public sealed class ApiOptions
{
    // TODO : Supply the API base address per environment. Never bundle server secrets.
    public Uri? BaseAddress { get; init; }
}
