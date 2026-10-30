namespace GoZar.Maui.Services.Api.Handlers;
public sealed class AuthenticationHandler : DelegatingHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        // TODO : Attach the agreed authorization scheme and implement expiry/refresh safely.
        // Intentionally not registered until that contract exists.
        return base.SendAsync(request, cancellationToken);
    }
}
