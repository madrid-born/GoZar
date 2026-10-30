using GoZar.Api.Common.Pagination;
using GoZar.Api.Features.Administration.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoZar.Api.Features.Administration;

[ApiController]
[Route("api/admin")]
[Authorize(Policy = "ContentAdministration")]
public sealed class AdministrationController(AdministrationService service) : ControllerBase
{
    // TODO : Review HTTP response semantics and API versioning before making these contracts public.
    [HttpPost("cities")]
    public Task<CreatedResourceResponse> CreateCity(UpsertCityRequest request, CancellationToken cancellationToken) =>
        service.CreateCityAsync(request, cancellationToken);

    [HttpPut("cities/{id:guid}")]
    public Task<bool> UpdateCity(Guid id, UpsertCityRequest request, CancellationToken cancellationToken) =>
        service.UpdateCityAsync(id, request, cancellationToken);

    [HttpPut("cities/{id:guid}/publication")]
    public Task<bool> SetCityPublication(Guid id, PublicationRequest request, CancellationToken cancellationToken) =>
        service.SetCityPublicationAsync(id, request, cancellationToken);

    [HttpPost("places")]
    public Task<CreatedResourceResponse> CreatePlace(UpsertPlaceRequest request, CancellationToken cancellationToken) =>
        service.CreatePlaceAsync(request, cancellationToken);

    [HttpPut("places/{id:guid}")]
    public Task<bool> UpdatePlace(Guid id, UpsertPlaceRequest request, CancellationToken cancellationToken) =>
        service.UpdatePlaceAsync(id, request, cancellationToken);

    [HttpPut("places/{id:guid}/publication")]
    public Task<bool> SetPlacePublication(Guid id, PublicationRequest request, CancellationToken cancellationToken) =>
        service.SetPlacePublicationAsync(id, request, cancellationToken);

    [HttpPost("transit-lines")]
    public Task<CreatedResourceResponse> CreateTransitLine(UpsertTransitLineRequest request, CancellationToken cancellationToken) =>
        service.CreateTransitLineAsync(request, cancellationToken);

    [HttpPut("transit-lines/{id:guid}")]
    public Task<bool> UpdateTransitLine(Guid id, UpsertTransitLineRequest request, CancellationToken cancellationToken) =>
        service.UpdateTransitLineAsync(id, request, cancellationToken);

    [HttpPut("transit-lines/{id:guid}/publication")]
    public Task<bool> SetTransitLinePublication(Guid id, PublicationRequest request, CancellationToken cancellationToken) =>
        service.SetTransitLinePublicationAsync(id, request, cancellationToken);

    [HttpPost("chapters")]
    public Task<CreatedResourceResponse> CreateChapter(UpsertChapterRequest request, CancellationToken cancellationToken) =>
        service.CreateChapterAsync(request, cancellationToken);

    [HttpPut("chapters/{id:guid}")]
    public Task<bool> UpdateChapter(Guid id, UpsertChapterRequest request, CancellationToken cancellationToken) =>
        service.UpdateChapterAsync(id, request, cancellationToken);

    [HttpPut("chapters/{id:guid}/publication")]
    public Task<bool> SetChapterPublication(Guid id, PublicationRequest request, CancellationToken cancellationToken) =>
        service.SetChapterPublicationAsync(id, request, cancellationToken);

    [HttpPost("lessons")]
    public Task<CreatedResourceResponse> CreateLesson(UpsertLessonRequest request, CancellationToken cancellationToken) =>
        service.CreateLessonAsync(request, cancellationToken);

    [HttpPut("lessons/{id:guid}")]
    public Task<bool> UpdateLesson(Guid id, UpsertLessonRequest request, CancellationToken cancellationToken) =>
        service.UpdateLessonAsync(id, request, cancellationToken);

    [HttpPut("lessons/{id:guid}/publication")]
    public Task<bool> SetLessonPublication(Guid id, PublicationRequest request, CancellationToken cancellationToken) =>
        service.SetLessonPublicationAsync(id, request, cancellationToken);

    [HttpPost("goals")]
    public Task<CreatedResourceResponse> CreateLearningGoal(UpsertLearningGoalRequest request, CancellationToken cancellationToken) =>
        service.CreateLearningGoalAsync(request, cancellationToken);

    [HttpPut("goals/{id:guid}")]
    public Task<bool> UpdateLearningGoal(Guid id, UpsertLearningGoalRequest request, CancellationToken cancellationToken) =>
        service.UpdateLearningGoalAsync(id, request, cancellationToken);

    [HttpPost("stories")]
    public Task<CreatedResourceResponse> CreateStory(UpsertStoryRequest request, CancellationToken cancellationToken) =>
        service.CreateStoryAsync(request, cancellationToken);

    [HttpPut("stories/{id:guid}")]
    public Task<bool> UpdateStory(Guid id, UpsertStoryRequest request, CancellationToken cancellationToken) =>
        service.UpdateStoryAsync(id, request, cancellationToken);

    [HttpPut("stories/{id:guid}/publication")]
    public Task<bool> SetStoryPublication(Guid id, PublicationRequest request, CancellationToken cancellationToken) =>
        service.SetStoryPublicationAsync(id, request, cancellationToken);

    [HttpPost("sources")]
    public Task<CreatedResourceResponse> CreateSource(UpsertSourceRequest request, CancellationToken cancellationToken) =>
        service.CreateSourceAsync(request, cancellationToken);

    [HttpPut("sources/{id:guid}")]
    public Task<bool> UpdateSource(Guid id, UpsertSourceRequest request, CancellationToken cancellationToken) =>
        service.UpdateSourceAsync(id, request, cancellationToken);

    [HttpPost("facts")]
    public Task<CreatedResourceResponse> CreateFact(UpsertFactRequest request, CancellationToken cancellationToken) =>
        service.CreateFactAsync(request, cancellationToken);

    [HttpPut("facts/{id:guid}")]
    public Task<bool> UpdateFact(Guid id, UpsertFactRequest request, CancellationToken cancellationToken) =>
        service.UpdateFactAsync(id, request, cancellationToken);

    [HttpPut("facts/{id:guid}/publication")]
    public Task<bool> SetFactPublication(Guid id, PublicationRequest request, CancellationToken cancellationToken) =>
        service.SetFactPublicationAsync(id, request, cancellationToken);

    [HttpPut("places/{placeId:guid}/geometry")]
    public Task<bool> SaveGeometry(Guid placeId, SaveGeometryRequest request, CancellationToken cancellationToken) =>
        service.SaveGeometryAsync(placeId, request, cancellationToken);

    [HttpPost("places/{placeId:guid}/aliases")]
    public Task<CreatedResourceResponse> AddAlias(Guid placeId, SaveAliasRequest request, CancellationToken cancellationToken) =>
        service.AddAliasAsync(placeId, request, cancellationToken);

    [HttpDelete("places/{placeId:guid}/aliases/{aliasId:guid}")]
    public Task<bool> RemoveAlias(Guid placeId, Guid aliasId, CancellationToken cancellationToken) =>
        service.RemoveAliasAsync(placeId, aliasId, cancellationToken);

    [HttpPost("relationships")]
    public Task<CreatedResourceResponse> SaveRelationship(SaveRelationshipRequest request, CancellationToken cancellationToken) =>
        service.SaveRelationshipAsync(request, cancellationToken);

    [HttpDelete("relationships/{relationshipId:guid}")]
    public Task<bool> RemoveRelationship(Guid relationshipId, CancellationToken cancellationToken) =>
        service.RemoveRelationshipAsync(relationshipId, cancellationToken);

    [HttpPut("places/{placeId:guid}/road")]
    public Task<bool> SaveRoadDetails(Guid placeId, SaveRoadDetailsRequest request, CancellationToken cancellationToken) =>
        service.SaveRoadDetailsAsync(placeId, request, cancellationToken);

    [HttpPut("places/{placeId:guid}/station")]
    public Task<bool> SaveStationDetails(Guid placeId, SaveStationDetailsRequest request, CancellationToken cancellationToken) =>
        service.SaveStationDetailsAsync(placeId, request, cancellationToken);

    [HttpPut("transit-lines/{lineId:guid}/stations")]
    public Task<bool> SetLineStations(Guid lineId, SetLineStationsRequest request, CancellationToken cancellationToken) =>
        service.SetLineStationsAsync(lineId, request, cancellationToken);

    [HttpPut("chapters/{chapterId:guid}/prerequisites")]
    public Task<bool> SetPrerequisites(Guid chapterId, SetPrerequisitesRequest request, CancellationToken cancellationToken) =>
        service.SetPrerequisitesAsync(chapterId, request, cancellationToken);

    [HttpGet("cities/{cityId:guid}/validation")]
    public Task<ValidationReportResponse> ValidateCity(Guid cityId, CancellationToken cancellationToken) =>
        service.ValidateCityAsync(cityId, cancellationToken);

    [HttpPost("catalog-imports")]
    public Task<ImportResultResponse> ImportCatalog(ImportCatalogRequest request, CancellationToken cancellationToken) =>
        service.ImportCatalogAsync(request, cancellationToken);

    [HttpGet("catalog-imports/{jobId:guid}")]
    public Task<ImportResultResponse> GetImportStatus(Guid jobId, CancellationToken cancellationToken) =>
        service.GetImportStatusAsync(jobId, cancellationToken);

    [HttpPost("cities/{cityId:guid}/content-packs")]
    public Task<CreatedResourceResponse> BuildContentPack(Guid cityId, CancellationToken cancellationToken) =>
        service.BuildContentPackAsync(cityId, cancellationToken);

    [HttpGet("cities")]
    public Task<PagedResponse<AdminCityResponse>> ListCityDrafts([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.ListCityDraftsAsync(page, cancellationToken);

    [HttpGet("cities/{id:guid}")]
    public Task<AdminCityResponse> GetCityDraft(Guid id, CancellationToken cancellationToken) =>
        service.GetCityDraftAsync(id, cancellationToken);

    [HttpGet("places")]
    public Task<PagedResponse<AdminPlaceResponse>> ListPlaceDrafts([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.ListPlaceDraftsAsync(page, cancellationToken);

    [HttpGet("places/{id:guid}")]
    public Task<AdminPlaceResponse> GetPlaceDraft(Guid id, CancellationToken cancellationToken) =>
        service.GetPlaceDraftAsync(id, cancellationToken);

    [HttpGet("transit-lines")]
    public Task<PagedResponse<AdminTransitLineResponse>> ListTransitLineDrafts([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.ListTransitLineDraftsAsync(page, cancellationToken);

    [HttpGet("transit-lines/{id:guid}")]
    public Task<AdminTransitLineResponse> GetTransitLineDraft(Guid id, CancellationToken cancellationToken) =>
        service.GetTransitLineDraftAsync(id, cancellationToken);

    [HttpGet("chapters")]
    public Task<PagedResponse<AdminChapterResponse>> ListChapterDrafts([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.ListChapterDraftsAsync(page, cancellationToken);

    [HttpGet("chapters/{id:guid}")]
    public Task<AdminChapterResponse> GetChapterDraft(Guid id, CancellationToken cancellationToken) =>
        service.GetChapterDraftAsync(id, cancellationToken);

    [HttpGet("lessons")]
    public Task<PagedResponse<AdminLessonResponse>> ListLessonDrafts([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.ListLessonDraftsAsync(page, cancellationToken);

    [HttpGet("lessons/{id:guid}")]
    public Task<AdminLessonResponse> GetLessonDraft(Guid id, CancellationToken cancellationToken) =>
        service.GetLessonDraftAsync(id, cancellationToken);

    [HttpGet("goals")]
    public Task<PagedResponse<AdminLearningGoalResponse>> ListLearningGoalDrafts([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.ListLearningGoalDraftsAsync(page, cancellationToken);

    [HttpGet("goals/{id:guid}")]
    public Task<AdminLearningGoalResponse> GetLearningGoalDraft(Guid id, CancellationToken cancellationToken) =>
        service.GetLearningGoalDraftAsync(id, cancellationToken);

    [HttpGet("stories")]
    public Task<PagedResponse<AdminStoryResponse>> ListStoryDrafts([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.ListStoryDraftsAsync(page, cancellationToken);

    [HttpGet("stories/{id:guid}")]
    public Task<AdminStoryResponse> GetStoryDraft(Guid id, CancellationToken cancellationToken) =>
        service.GetStoryDraftAsync(id, cancellationToken);

    [HttpGet("sources")]
    public Task<PagedResponse<AdminSourceResponse>> ListSourceDrafts([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.ListSourceDraftsAsync(page, cancellationToken);

    [HttpGet("sources/{id:guid}")]
    public Task<AdminSourceResponse> GetSourceDraft(Guid id, CancellationToken cancellationToken) =>
        service.GetSourceDraftAsync(id, cancellationToken);

    [HttpGet("facts")]
    public Task<PagedResponse<AdminFactResponse>> ListFactDrafts([FromQuery] PageRequest page, CancellationToken cancellationToken) =>
        service.ListFactDraftsAsync(page, cancellationToken);

    [HttpGet("facts/{id:guid}")]
    public Task<AdminFactResponse> GetFactDraft(Guid id, CancellationToken cancellationToken) =>
        service.GetFactDraftAsync(id, cancellationToken);

    [HttpPost("assets")]
    public async Task<UploadedAssetResponse> UploadAsset(IFormFile file, CancellationToken cancellationToken)
    {
        // TODO : Choose explicit upload limits and allowed content types before implementing storage.
        await using var stream = file.OpenReadStream();
        return await service.UploadAssetAsync(stream, file.ContentType, cancellationToken);
    }
}
