using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Progress.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record PlaceProgressResponse(Guid PlaceId, IReadOnlyList<SkillProgressResponse> Skills);
