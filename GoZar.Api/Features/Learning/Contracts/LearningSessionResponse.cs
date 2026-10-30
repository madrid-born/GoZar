using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Learning.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record LearningSessionResponse(Guid Id, Guid CityId, string Status, IReadOnlyList<SessionItemResponse> Items, Guid? CurrentItemId);
