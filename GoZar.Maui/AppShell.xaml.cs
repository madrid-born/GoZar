using GoZar.Maui.Services;
using Microsoft.Extensions.DependencyInjection;
using GoZar.Maui.Features.Authentication;
using GoZar.Maui.Features.Today;
using GoZar.Maui.Features.Explore;
using GoZar.Maui.Features.Stories;
using GoZar.Maui.Features.Profile;
namespace GoZar.Maui;

public partial class AppShell : Shell
{
    public AppShell(IServiceProvider services)
    {
        InitializeComponent();
        WelcomeContent.ContentTemplate = new DataTemplate(() => services.GetRequiredService<WelcomePage>());
        TodayContent.ContentTemplate = new DataTemplate(() => services.GetRequiredService<TodayPage>());
        MapContent.ContentTemplate = new DataTemplate(() => services.GetRequiredService<CityMapPage>());
        StoriesContent.ContentTemplate = new DataTemplate(() => services.GetRequiredService<StoriesPage>());
        ProgressContent.ContentTemplate = new DataTemplate(() => services.GetRequiredService<ProgressPage>());
        ServiceRegistration.RegisterRoutes();
    }
    public void ShowMainTabs() { MainTabs.IsVisible = true; AuthenticationItem.IsVisible = false; }
    public void ShowAuthentication() { AuthenticationItem.IsVisible = true; MainTabs.IsVisible = false; }
}
