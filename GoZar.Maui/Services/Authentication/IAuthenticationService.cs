namespace GoZar.Maui.Services.Authentication;
public interface IAuthenticationService
{
    Task RestoreSessionAsync(CancellationToken cancellationToken = default);
    Task SignOutAsync(CancellationToken cancellationToken = default);
    // TODO : Define login/registration/verification methods after agreeing AuthenticationApi contracts.
}
