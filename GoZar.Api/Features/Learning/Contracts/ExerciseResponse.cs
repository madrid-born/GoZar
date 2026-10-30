using System.Text.Json;

namespace GoZar.Api.Features.Learning.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
// TODO : Replace the provisional JSON payload with validated exercise-specific contracts/discriminators.
public sealed record ExerciseResponse(Guid Id, string ExerciseType, string SkillCode, string Prompt, JsonElement Content, IReadOnlyList<ExerciseOptionResponse> Options);
