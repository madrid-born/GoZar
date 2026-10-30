using GoZar.Api.Domain.Learning;

namespace GoZar.Api.Features.Reviews;

public sealed record AnswerEvidence(Guid SessionId, string SkillCode, bool IsCorrect, DateTimeOffset AcceptedAtUtc);
public sealed record ReviewSchedule(DateTimeOffset NextReviewAtUtc, string? SchedulerStateJson);
public sealed class ReviewScheduler
{
    public ReviewSchedule ScheduleNext(UserSkillProgress progress, AnswerEvidence evidence)
    {
        // TODO : Choose a scheduler (simple intervals or a calibrated algorithm), accounting for history and separate sessions.
        throw new NotImplementedException();
    }
}
