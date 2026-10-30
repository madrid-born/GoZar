using GoZar.Maui.Features.Authentication;
using GoZar.Maui.Features.Development;
using GoZar.Maui.Features.Explore;
using GoZar.Maui.Features.Learning;
using GoZar.Maui.Features.Onboarding;
using GoZar.Maui.Features.Profile;
using GoZar.Maui.Features.Reviews;
using GoZar.Maui.Features.Stories;
using GoZar.Maui.Features.Today;
using GoZar.Maui.Services.Api;
using GoZar.Maui.Services.Authentication;
using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Services.Storage;

namespace GoZar.Maui.Services;

public static class ServiceRegistration
{
    public static IServiceCollection AddGoZarFrontend(this IServiceCollection services)
    {
        services.AddSingleton<AppShell>();
        services.AddSingleton<INavigationService, NavigationService>();
        services.AddSingleton<PreferencesStore>();
        services.AddSingleton<TokenStore>();
        services.AddSingleton<IAuthenticationService, AuthenticationService>();
        services.AddSingleton(new ApiOptions());
        // TODO : Configure server address, authentication handler and timeout/retry policy per environment.
        services.AddSingleton(new HttpClient { Timeout = TimeSpan.FromSeconds(30) });
        services.AddSingleton<ApiClient>();
        services.AddSingleton<CatalogApi>();
        services.AddSingleton<LearningApi>();
        services.AddSingleton<ProfileApi>();
        services.AddSingleton<StoriesApi>();
        services.AddSingleton<AuthenticationApi>();
        services.AddTransient<WelcomeViewModel>();
        services.AddTransient<WelcomePage>();
        services.AddTransient<LoginViewModel>();
        services.AddTransient<LoginPage>();
        services.AddTransient<RegisterViewModel>();
        services.AddTransient<RegisterPage>();
        services.AddTransient<VerifyEmailViewModel>();
        services.AddTransient<VerifyEmailPage>();
        services.AddTransient<ForgotPasswordViewModel>();
        services.AddTransient<ForgotPasswordPage>();
        services.AddTransient<ResetPasswordViewModel>();
        services.AddTransient<ResetPasswordPage>();
        services.AddTransient<CitySelectionViewModel>();
        services.AddTransient<CitySelectionPage>();
        services.AddTransient<LearningGoalsViewModel>();
        services.AddTransient<LearningGoalsPage>();
        services.AddTransient<ImportantPlacesViewModel>();
        services.AddTransient<ImportantPlacesPage>();
        services.AddTransient<PlacementViewModel>();
        services.AddTransient<PlacementPage>();
        services.AddTransient<TodayViewModel>();
        services.AddTransient<TodayPage>();
        services.AddTransient<LearningPathViewModel>();
        services.AddTransient<LearningPathPage>();
        services.AddTransient<LessonViewModel>();
        services.AddTransient<LessonPage>();
        services.AddTransient<ExerciseViewModel>();
        services.AddTransient<ExercisePage>();
        services.AddTransient<SessionCompleteViewModel>();
        services.AddTransient<SessionCompletePage>();
        services.AddTransient<CityMapViewModel>();
        services.AddTransient<CityMapPage>();
        services.AddTransient<PlaceDetailsViewModel>();
        services.AddTransient<PlaceDetailsPage>();
        services.AddTransient<ReviewsViewModel>();
        services.AddTransient<ReviewsPage>();
        services.AddTransient<StoriesViewModel>();
        services.AddTransient<StoriesPage>();
        services.AddTransient<StoryDetailsViewModel>();
        services.AddTransient<StoryDetailsPage>();
        services.AddTransient<ProgressViewModel>();
        services.AddTransient<ProgressPage>();
        services.AddTransient<SettingsViewModel>();
        services.AddTransient<SettingsPage>();
        services.AddTransient<DownloadsViewModel>();
        services.AddTransient<DownloadsPage>();
#if DEBUG
        services.AddTransient<ScreenCatalogPage>();
#endif
        return services;
    }

    public static void RegisterRoutes()
    {
        Routing.RegisterRoute(Routes.Login, typeof(LoginPage));
        Routing.RegisterRoute(Routes.Register, typeof(RegisterPage));
        Routing.RegisterRoute(Routes.VerifyEmail, typeof(VerifyEmailPage));
        Routing.RegisterRoute(Routes.ForgotPassword, typeof(ForgotPasswordPage));
        Routing.RegisterRoute(Routes.ResetPassword, typeof(ResetPasswordPage));
        Routing.RegisterRoute(Routes.CitySelection, typeof(CitySelectionPage));
        Routing.RegisterRoute(Routes.LearningGoals, typeof(LearningGoalsPage));
        Routing.RegisterRoute(Routes.ImportantPlaces, typeof(ImportantPlacesPage));
        Routing.RegisterRoute(Routes.Placement, typeof(PlacementPage));
        Routing.RegisterRoute(Routes.LearningPath, typeof(LearningPathPage));
        Routing.RegisterRoute(Routes.Lesson, typeof(LessonPage));
        Routing.RegisterRoute(Routes.Exercise, typeof(ExercisePage));
        Routing.RegisterRoute(Routes.SessionComplete, typeof(SessionCompletePage));
        Routing.RegisterRoute(Routes.PlaceDetails, typeof(PlaceDetailsPage));
        Routing.RegisterRoute(Routes.Reviews, typeof(ReviewsPage));
        Routing.RegisterRoute(Routes.StoryDetails, typeof(StoryDetailsPage));
        Routing.RegisterRoute(Routes.Settings, typeof(SettingsPage));
        Routing.RegisterRoute(Routes.Downloads, typeof(DownloadsPage));
#if DEBUG
        Routing.RegisterRoute(Routes.ScreenCatalog, typeof(ScreenCatalogPage));
#endif
    }
}
