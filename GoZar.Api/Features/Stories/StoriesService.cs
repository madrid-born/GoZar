using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Stories.Contracts;
using GoZar.Api.Models;

namespace GoZar.Api.Features.Stories;

public sealed class StoriesService(AppDbContext db, TimeProvider clock)
{
    private readonly AppDbContext _db = db;
    private readonly TimeProvider _clock = clock;
    // TODO : Read only published editorial material and reviewed sources; generate permitted image URLs through storage.
    // TODO : Inject the feature policies/planners below as each operation is implemented.
    public Task<PagedResponse<StorySummaryResponse>> GetStoriesAsync(Guid cityId, PageRequest page, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetStories with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("StoriesService.GetStoriesAsync");
    }

    public Task<StoryDetailsResponse> GetStoryAsync(Guid storyId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetStory with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("StoriesService.GetStoryAsync");
    }
}
