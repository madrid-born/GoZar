using GoZar.Api.Domain.Learning;
using GoZar.Api.Features.Reviews;

namespace GoZar.Api.Features.Progress;

public sealed class MasteryPolicy
{
    public string Evaluate(UserSkillProgress progress, IReadOnlyList<AnswerEvidence> evidence)
    {
        // TODO : Define introduced/practicing/remembered criteria across skills and sessions; avoid lifetime-correct-count mastery.
        throw new NotImplementedException();
    }
}
