using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Learning.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record SessionItemResponse(Guid Id, int Position, string ItemKind, Guid? LessonId, Guid? ExerciseId);
