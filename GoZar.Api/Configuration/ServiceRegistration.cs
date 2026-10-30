using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Errors;
using GoZar.Api.Common.Idempotency;
using GoZar.Api.Data.Importing;
using GoZar.Api.Data.Seeding;
using GoZar.Api.Features.Administration;
using GoZar.Api.Features.Catalog;
using GoZar.Api.Features.Learning;
using GoZar.Api.Features.Learning.Exercises;
using GoZar.Api.Features.Learning.Planning;
using GoZar.Api.Features.Offline;
using GoZar.Api.Features.Onboarding;
using GoZar.Api.Features.Placement;
using GoZar.Api.Features.Profile;
using GoZar.Api.Features.Progress;
using GoZar.Api.Features.Reviews;
using GoZar.Api.Features.Stories;
using GoZar.Api.Infrastructure.BackgroundJobs;
using GoZar.Api.Infrastructure.Files;

namespace GoZar.Api.Configuration;

public static class ServiceRegistration
{
    public static IServiceCollection AddGoZarLearning(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpContextAccessor();
        services.AddScoped<ICurrentUser, CurrentUser>();
        services.AddSingleton(TimeProvider.System);
        services.AddExceptionHandler<ApiExceptionHandler>();
        services.AddProblemDetails();
        services.AddAuthorization(options => options.AddPolicy("ContentAdministration", policy => policy.RequireRole("Administrator")));
        // TODO : Review the administrator role name and provision it through trusted operations, never public registration.
        services.Configure<LearningOptions>(configuration.GetSection("Learning"));
        services.Configure<ContentStorageOptions>(configuration.GetSection("ContentStorage"));
        services.AddScoped<CatalogService>();
        services.AddScoped<OnboardingService>();
        services.AddScoped<PlacementService>();
        services.AddScoped<LearningSessionService>();
        services.AddScoped<ReviewService>();
        services.AddScoped<ProgressService>();
        services.AddScoped<StoriesService>();
        services.AddScoped<ProfileService>();
        services.AddScoped<ContentPackService>();
        services.AddScoped<SynchronizationService>();
        services.AddScoped<AdministrationService>();
        services.AddScoped<SubmissionDeduplicator>();
        services.AddScoped<TodayService>();
        services.AddScoped<MapService>();
        services.AddScoped<SessionPlanner>();
        services.AddScoped<CandidateRanker>();
        services.AddScoped<CurriculumPolicy>();
        services.AddScoped<ExerciseFactory>();
        services.AddScoped<AnswerEvaluator>();
        services.AddScoped<ReviewScheduler>();
        services.AddScoped<MasteryPolicy>();
        services.AddScoped<StreakService>();
        services.AddScoped<ReferenceDataSeeder>();
        services.AddScoped<OsmImportService>();
        services.AddScoped<CatalogValidationService>();
        services.AddScoped<ContentStorage>();
        services.AddScoped<ContentPackBuilder>();
        services.AddScoped<RecognitionExerciseBuilder>();
        services.AddScoped<LocatePlaceExerciseBuilder>();
        services.AddScoped<RouteOrderingExerciseBuilder>();
        return services;
    }
}
