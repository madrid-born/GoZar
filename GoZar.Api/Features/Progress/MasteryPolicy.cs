namespace GoZar.Api.Features.Progress;

public sealed class MasteryPolicy
{
    public string Evaluate(GoZar.Api.Domain.Learning.UserSkillProgress progress, IReadOnlyList<GoZar.Api.Features.Reviews.AnswerEvidence> evidence)
    {
        // TODO : Define introduced/practicing/remembered criteria across skills and sessions; avoid lifetime-correct-count mastery.
        throw new NotImplementedException();
    }
}
