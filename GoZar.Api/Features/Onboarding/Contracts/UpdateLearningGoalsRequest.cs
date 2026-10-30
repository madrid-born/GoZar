using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Onboarding.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record UpdateLearningGoalsRequest(Guid CityId, [Required] IReadOnlyList<Guid> GoalIds);
