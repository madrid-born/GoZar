using System.Text.Json;

namespace GoZar.Api.Features.Placement.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record SubmitPlacementAnswerRequest(Guid ExerciseId, Guid ClientSubmissionId, JsonElement Answer);
