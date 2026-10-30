using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Stories.Contracts;
namespace GoZar.Api.Features.Stories;

[ApiController]
[Route("api/stories")]
[Authorize]
public sealed class StoriesController(StoriesService service) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpGet]
    public Task<PagedResponse<StorySummaryResponse>> GetStories([FromQuery] Guid cityId, [FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.GetStoriesAsync(cityId, page, cancellationToken);

    [HttpGet("{storyId:guid}")]
    public Task<StoryDetailsResponse> GetStory(Guid storyId, CancellationToken cancellationToken) =>
        service.GetStoryAsync(storyId, cancellationToken);
}
