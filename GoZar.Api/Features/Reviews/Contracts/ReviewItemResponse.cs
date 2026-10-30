using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Reviews.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record ReviewItemResponse(Guid LearningTargetId, string SkillCode, string DisplayName, DateTimeOffset DueAtUtc);
