using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Catalog.Contracts;
using GoZar.Api.Features.Profile.Contracts;
using GoZar.Api.Features.Stories.Contracts;
using GoZar.Api.Models;

namespace GoZar.Api.Features.Profile;

public sealed class ProfileService(AppDbContext db, TimeProvider clock)
{
    private readonly AppDbContext _db = db;
    private readonly TimeProvider _clock = clock;
    // TODO : Validate IANA/platform timezone identifiers and reminder policy; separate device-only settings and server preferences.
    // TODO : Inject the feature policies/planners below as each operation is implemented.
    public Task<ProfileResponse> GetProfileAsync(string userId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetProfile with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProfileService.GetProfileAsync");
    }

    public Task<PreferencesResponse> GetPreferencesAsync(string userId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetPreferences with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProfileService.GetPreferencesAsync");
    }

    public Task<PreferencesResponse> UpdatePreferencesAsync(string userId, UpdatePreferencesRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement UpdatePreferences with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProfileService.UpdatePreferencesAsync");
    }

    public Task<PagedResponse<PlaceSummaryResponse>> GetSavedPlacesAsync(string userId, PageRequest page, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetSavedPlaces with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProfileService.GetSavedPlacesAsync");
    }

    public Task<bool> SavePlaceAsync(string userId, SavePlaceRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement SavePlace with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProfileService.SavePlaceAsync");
    }

    public Task<bool> RemoveSavedPlaceAsync(string userId, Guid placeId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement RemoveSavedPlace with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProfileService.RemoveSavedPlaceAsync");
    }

    public Task<PagedResponse<StorySummaryResponse>> GetSavedStoriesAsync(string userId, PageRequest page, CancellationToken cancellationToken = default)
    {
        // TODO : Implement GetSavedStories with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProfileService.GetSavedStoriesAsync");
    }

    public Task<bool> SaveStoryAsync(string userId, SaveStoryRequest request, CancellationToken cancellationToken = default)
    {
        // TODO : Implement SaveStory with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProfileService.SaveStoryAsync");
    }

    public Task<bool> RemoveSavedStoryAsync(string userId, Guid storyId, CancellationToken cancellationToken = default)
    {
        // TODO : Implement RemoveSavedStory with validation, ownership/publication checks and cancellation.
        // TODO : Coordinate writes transactionally; never return success before persistence commits.
        throw new NotImplementedException("ProfileService.RemoveSavedStoryAsync");
    }
}
