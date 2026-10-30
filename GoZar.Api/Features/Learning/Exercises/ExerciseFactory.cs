namespace GoZar.Api.Features.Learning.Exercises;

public sealed class ExerciseFactory
{
    public Task<GoZar.Api.Domain.Learning.Exercise> CreateAsync(Guid targetId, string skillCode, Guid sessionItemId, CancellationToken cancellationToken = default)
    {
        // TODO : Select an agreed exercise builder and persist both public content and private evaluation data.
        throw new NotImplementedException();
    }
}
