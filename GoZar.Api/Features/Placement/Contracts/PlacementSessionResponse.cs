using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Placement.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PlacementSessionResponse(Guid SessionId, IReadOnlyList<GoZar.Api.Features.Learning.Contracts.ExerciseResponse> Exercises);
