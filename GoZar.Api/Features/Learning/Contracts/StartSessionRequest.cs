using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Learning.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record StartSessionRequest(Guid CityId, Guid ClientRequestId, string SessionKind = "daily", Guid? ChapterId = null);
