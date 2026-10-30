using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Learning.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record LessonResponse(Guid Id, string Title, string? TeachingText, IReadOnlyList<GoZar.Api.Features.Catalog.Contracts.PlaceSummaryResponse> Places);
