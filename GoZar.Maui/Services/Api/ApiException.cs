using System.Net;

namespace GoZar.Maui.Services.Api;
public sealed class ApiException(HttpStatusCode statusCode) : Exception($"API request failed with status {(int)statusCode}.")
{
    public HttpStatusCode StatusCode { get; } = statusCode;
    // TODO : Map the agreed API error envelope to safe localized UI messages.
}
