using System.Net.Http.Json;

namespace GoZar.Maui.Services.Api;

public sealed class ApiClient(HttpClient httpClient, ApiOptions options)
{
    public async Task<T?> GetAsync<T>(string relativePath, CancellationToken cancellationToken = default)
    {
        var baseAddress = options.BaseAddress ?? throw new InvalidOperationException("TODO : Configure API base address first.");
        if (!Uri.TryCreate(relativePath, UriKind.Relative, out _) || relativePath.StartsWith("//", StringComparison.Ordinal))
            throw new ArgumentException("API endpoints must be relative paths.", nameof(relativePath));
        using var response = await httpClient.GetAsync(new Uri(baseAddress, relativePath), cancellationToken);
        if (!response.IsSuccessStatusCode) throw new ApiException(response.StatusCode);
        return await response.Content.ReadFromJsonAsync<T>(cancellationToken);
    }
    // TODO : Add mutations, serialization options, authentication/refresh and error parsing after agreeing API contracts.
}
