namespace GoZar.Maui.Services.Storage;
public sealed class TokenStore
{
    private const string AccessTokenKey = "gozar.access-token";
    public Task<string?> GetAccessTokenAsync() => SecureStorage.Default.GetAsync(AccessTokenKey);
    public Task SetAccessTokenAsync(string token) => SecureStorage.Default.SetAsync(AccessTokenKey, token);
    public void Clear() => SecureStorage.Default.Remove(AccessTokenKey);
    // TODO : Decide refresh-token storage/lifecycle with the server authentication flow.
}
