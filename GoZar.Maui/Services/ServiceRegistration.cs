using Microsoft.Extensions.DependencyInjection;
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
        services.AddTransient<global::GoZar.Maui.Features.Authentication.WelcomeViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.WelcomePage>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.LoginViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.LoginPage>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.RegisterViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.RegisterPage>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.VerifyEmailViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.VerifyEmailPage>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.ForgotPasswordViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.ForgotPasswordPage>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.ResetPasswordViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Authentication.ResetPasswordPage>();
        services.AddTransient<global::GoZar.Maui.Features.Onboarding.CitySelectionViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Onboarding.CitySelectionPage>();
        services.AddTransient<global::GoZar.Maui.Features.Onboarding.LearningGoalsViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Onboarding.LearningGoalsPage>();
        services.AddTransient<global::GoZar.Maui.Features.Onboarding.ImportantPlacesViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Onboarding.ImportantPlacesPage>();
        services.AddTransient<global::GoZar.Maui.Features.Onboarding.PlacementViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Onboarding.PlacementPage>();
        services.AddTransient<global::GoZar.Maui.Features.Today.TodayViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Today.TodayPage>();
        services.AddTransient<global::GoZar.Maui.Features.Learning.LearningPathViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Learning.LearningPathPage>();
        services.AddTransient<global::GoZar.Maui.Features.Learning.LessonViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Learning.LessonPage>();
        services.AddTransient<global::GoZar.Maui.Features.Learning.ExerciseViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Learning.ExercisePage>();
        services.AddTransient<global::GoZar.Maui.Features.Learning.SessionCompleteViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Learning.SessionCompletePage>();
        services.AddTransient<global::GoZar.Maui.Features.Explore.CityMapViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Explore.CityMapPage>();
        services.AddTransient<global::GoZar.Maui.Features.Explore.PlaceDetailsViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Explore.PlaceDetailsPage>();
        services.AddTransient<global::GoZar.Maui.Features.Reviews.ReviewsViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Reviews.ReviewsPage>();
        services.AddTransient<global::GoZar.Maui.Features.Stories.StoriesViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Stories.StoriesPage>();
        services.AddTransient<global::GoZar.Maui.Features.Stories.StoryDetailsViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Stories.StoryDetailsPage>();
        services.AddTransient<global::GoZar.Maui.Features.Profile.ProgressViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Profile.ProgressPage>();
        services.AddTransient<global::GoZar.Maui.Features.Profile.SettingsViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Profile.SettingsPage>();
        services.AddTransient<global::GoZar.Maui.Features.Profile.DownloadsViewModel>();
        services.AddTransient<global::GoZar.Maui.Features.Profile.DownloadsPage>();
#if DEBUG
        services.AddTransient<global::GoZar.Maui.Features.Development.ScreenCatalogPage>();
#endif
        return services;
    }

    public static void RegisterRoutes()
    {
        Routing.RegisterRoute(Routes.Login, typeof(global::GoZar.Maui.Features.Authentication.LoginPage));
        Routing.RegisterRoute(Routes.Register, typeof(global::GoZar.Maui.Features.Authentication.RegisterPage));
        Routing.RegisterRoute(Routes.VerifyEmail, typeof(global::GoZar.Maui.Features.Authentication.VerifyEmailPage));
        Routing.RegisterRoute(Routes.ForgotPassword, typeof(global::GoZar.Maui.Features.Authentication.ForgotPasswordPage));
        Routing.RegisterRoute(Routes.ResetPassword, typeof(global::GoZar.Maui.Features.Authentication.ResetPasswordPage));
        Routing.RegisterRoute(Routes.CitySelection, typeof(global::GoZar.Maui.Features.Onboarding.CitySelectionPage));
        Routing.RegisterRoute(Routes.LearningGoals, typeof(global::GoZar.Maui.Features.Onboarding.LearningGoalsPage));
        Routing.RegisterRoute(Routes.ImportantPlaces, typeof(global::GoZar.Maui.Features.Onboarding.ImportantPlacesPage));
        Routing.RegisterRoute(Routes.Placement, typeof(global::GoZar.Maui.Features.Onboarding.PlacementPage));
        Routing.RegisterRoute(Routes.LearningPath, typeof(global::GoZar.Maui.Features.Learning.LearningPathPage));
        Routing.RegisterRoute(Routes.Lesson, typeof(global::GoZar.Maui.Features.Learning.LessonPage));
        Routing.RegisterRoute(Routes.Exercise, typeof(global::GoZar.Maui.Features.Learning.ExercisePage));
        Routing.RegisterRoute(Routes.SessionComplete, typeof(global::GoZar.Maui.Features.Learning.SessionCompletePage));
        Routing.RegisterRoute(Routes.PlaceDetails, typeof(global::GoZar.Maui.Features.Explore.PlaceDetailsPage));
        Routing.RegisterRoute(Routes.Reviews, typeof(global::GoZar.Maui.Features.Reviews.ReviewsPage));
        Routing.RegisterRoute(Routes.StoryDetails, typeof(global::GoZar.Maui.Features.Stories.StoryDetailsPage));
        Routing.RegisterRoute(Routes.Settings, typeof(global::GoZar.Maui.Features.Profile.SettingsPage));
        Routing.RegisterRoute(Routes.Downloads, typeof(global::GoZar.Maui.Features.Profile.DownloadsPage));
#if DEBUG
        Routing.RegisterRoute(Routes.ScreenCatalog, typeof(global::GoZar.Maui.Features.Development.ScreenCatalogPage));
#endif
    }
}
