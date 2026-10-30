using System.ComponentModel.DataAnnotations;

namespace GoZar.Api.Features.Offline.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record SubmitAnswerBatchRequest([Required] IReadOnlyList<OfflineAnswerRequest> Answers);
