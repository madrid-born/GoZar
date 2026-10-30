using GoZar.Maui.Services.Api;
using GoZar.Maui.Services.Storage;

namespace GoZar.Maui.Services.Authentication;

public sealed class AuthenticationService(AuthenticationApi api, TokenStore tokenStore) : IAuthenticationService
{
    private readonly AuthenticationApi _api = api;
    public Task RestoreSessionAsync(CancellationToken cancellationToken = default)
    {
        // TODO : Validate/refresh credentials through the API, then select onboarding or Today.
        // Possessing a stored token is not proof of a valid session.
        throw new NotSupportedException("TODO : Implement session restoration against the API.");
    }
    public Task SignOutAsync(CancellationToken cancellationToken = default)
    {
        // TODO : Revoke server session, clear account-scoped cache and reset navigation.
        tokenStore.Clear();
        return Task.CompletedTask;
    }
}
