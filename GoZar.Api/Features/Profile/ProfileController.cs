using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Catalog.Contracts;
using GoZar.Api.Features.Profile.Contracts;
using GoZar.Api.Features.Stories.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoZar.Api.Features.Profile;

[ApiController]
[Route("api/profile")]
[Authorize]
public sealed class ProfileController(ProfileService service, ICurrentUser currentUser) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpGet]
    public Task<ProfileResponse> GetProfile(CancellationToken cancellationToken) =>
        service.GetProfileAsync(currentUser.RequiredUserId, cancellationToken);

    [HttpGet("preferences")]
    public Task<PreferencesResponse> GetPreferences(CancellationToken cancellationToken) =>
        service.GetPreferencesAsync(currentUser.RequiredUserId, cancellationToken);

    [HttpPut("preferences")]
    public Task<PreferencesResponse> UpdatePreferences(UpdatePreferencesRequest request, CancellationToken cancellationToken) =>
        service.UpdatePreferencesAsync(currentUser.RequiredUserId, request, cancellationToken);

    [HttpGet("saved-places")]
    public Task<PagedResponse<PlaceSummaryResponse>> GetSavedPlaces([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.GetSavedPlacesAsync(currentUser.RequiredUserId, page, cancellationToken);

    [HttpPost("saved-places")]
    public Task<bool> SavePlace(SavePlaceRequest request, CancellationToken cancellationToken) =>
        service.SavePlaceAsync(currentUser.RequiredUserId, request, cancellationToken);

    [HttpDelete("saved-places/{placeId:guid}")]
    public Task<bool> RemoveSavedPlace(Guid placeId, CancellationToken cancellationToken) =>
        service.RemoveSavedPlaceAsync(currentUser.RequiredUserId, placeId, cancellationToken);

    [HttpGet("saved-stories")]
    public Task<PagedResponse<StorySummaryResponse>> GetSavedStories([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.GetSavedStoriesAsync(currentUser.RequiredUserId, page, cancellationToken);

    [HttpPost("saved-stories")]
    public Task<bool> SaveStory(SaveStoryRequest request, CancellationToken cancellationToken) =>
        service.SaveStoryAsync(currentUser.RequiredUserId, request, cancellationToken);

    [HttpDelete("saved-stories/{storyId:guid}")]
    public Task<bool> RemoveSavedStory(Guid storyId, CancellationToken cancellationToken) =>
        service.RemoveSavedStoryAsync(currentUser.RequiredUserId, storyId, cancellationToken);
}
