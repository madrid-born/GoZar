namespace GoZar.Api.Features.Learning.Planning;

public sealed class CurriculumPolicy
{
    public Task<IReadOnlyList<Guid>> GetEligibleLessonsAsync(string userId, Guid cityId, CancellationToken cancellationToken = default)
    {
        // TODO : Respect publication, prerequisites, prior knowledge and a coherent geographic teaching sequence.
        throw new NotImplementedException();
    }
    public Task ValidatePrerequisitesAsync(Guid chapterId, IReadOnlyList<Guid> prerequisites, CancellationToken cancellationToken = default)
    {
        // TODO : Reject cycles, self-reference and cross-city prerequisites.
        throw new NotImplementedException();
    }
}
