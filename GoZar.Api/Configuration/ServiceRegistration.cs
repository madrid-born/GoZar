using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Common.Errors;
using GoZar.Api.Common.Idempotency;

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
        services.AddScoped<GoZar.Api.Features.Catalog.CatalogService>();
        services.AddScoped<GoZar.Api.Features.Onboarding.OnboardingService>();
        services.AddScoped<GoZar.Api.Features.Placement.PlacementService>();
        services.AddScoped<GoZar.Api.Features.Learning.LearningSessionService>();
        services.AddScoped<GoZar.Api.Features.Reviews.ReviewService>();
        services.AddScoped<GoZar.Api.Features.Progress.ProgressService>();
        services.AddScoped<GoZar.Api.Features.Stories.StoriesService>();
        services.AddScoped<GoZar.Api.Features.Profile.ProfileService>();
        services.AddScoped<GoZar.Api.Features.Offline.ContentPackService>();
        services.AddScoped<GoZar.Api.Features.Offline.SynchronizationService>();
        services.AddScoped<GoZar.Api.Features.Administration.AdministrationService>();
        services.AddScoped<SubmissionDeduplicator>();
        services.AddScoped<GoZar.Api.Features.Learning.TodayService>();
        services.AddScoped<GoZar.Api.Features.Catalog.MapService>();
        services.AddScoped<GoZar.Api.Features.Learning.Planning.SessionPlanner>();
        services.AddScoped<GoZar.Api.Features.Learning.Planning.CandidateRanker>();
        services.AddScoped<GoZar.Api.Features.Learning.Planning.CurriculumPolicy>();
        services.AddScoped<GoZar.Api.Features.Learning.Exercises.ExerciseFactory>();
        services.AddScoped<GoZar.Api.Features.Learning.Exercises.AnswerEvaluator>();
        services.AddScoped<GoZar.Api.Features.Reviews.ReviewScheduler>();
        services.AddScoped<GoZar.Api.Features.Progress.MasteryPolicy>();
        services.AddScoped<GoZar.Api.Features.Progress.StreakService>();
        services.AddScoped<GoZar.Api.Data.Seeding.ReferenceDataSeeder>();
        services.AddScoped<GoZar.Api.Data.Importing.OsmImportService>();
        services.AddScoped<GoZar.Api.Data.Importing.CatalogValidationService>();
        services.AddScoped<GoZar.Api.Infrastructure.Files.ContentStorage>();
        services.AddScoped<GoZar.Api.Infrastructure.BackgroundJobs.ContentPackBuilder>();
        services.AddScoped<GoZar.Api.Features.Learning.Exercises.RecognitionExerciseBuilder>();
        services.AddScoped<GoZar.Api.Features.Learning.Exercises.LocatePlaceExerciseBuilder>();
        services.AddScoped<GoZar.Api.Features.Learning.Exercises.RouteOrderingExerciseBuilder>();
        return services;
    }
}
