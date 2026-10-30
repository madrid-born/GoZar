using GoZar.Api.Features.Learning.Contracts;

namespace GoZar.Api.Features.Offline.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record SynchronizationItemResponse(Guid ClientSubmissionId, string Status, AnswerResultResponse? Result, string? ErrorCode);
