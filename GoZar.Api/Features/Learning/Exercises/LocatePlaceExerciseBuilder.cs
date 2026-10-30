using GoZar.Api.Domain.Learning;

namespace GoZar.Api.Features.Learning.Exercises;

public sealed class LocatePlaceExerciseBuilder
{
    public Task<Exercise> BuildAsync(Guid targetId, Guid sessionItemId, CancellationToken cancellationToken = default)
    {
        // TODO : Generate a LocatePlace exercise from reviewed content; reject ambiguous questions and keep answer keys private.
        // TODO : Agree public and private payload formats with AnswerEvaluator and the MAUI exercise view.
        throw new NotImplementedException();
    }
}
