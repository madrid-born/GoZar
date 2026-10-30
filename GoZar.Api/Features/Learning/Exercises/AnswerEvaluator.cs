namespace GoZar.Api.Features.Learning.Exercises;

public sealed record EvaluationResult(bool IsCorrect, string? Explanation);
public sealed class AnswerEvaluator
{
    public Task<EvaluationResult> EvaluateAsync(GoZar.Api.Domain.Learning.Exercise exercise, System.Text.Json.JsonElement answer, CancellationToken cancellationToken = default)
    {
        // TODO : Validate payload by exercise type; verify option ownership, map tolerance or route ordering.
        // Correct-answer data is private; only reveal permitted feedback after an accepted submission.
        throw new NotImplementedException();
    }
}
