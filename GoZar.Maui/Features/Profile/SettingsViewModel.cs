using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Profile;

public sealed class SettingsViewModel : BaseViewModel
{
    public SettingsViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "تنظیمات";
        Description = "با ریتم خودت یاد بگیر.";
        TodoMessage = "Decide server versus device preferences, notification permissions and account settings.";
        // TODO : Decide server versus device preferences, notification permissions and account settings.
        Links.Add(new NavigationLink("علاقه‌ها", Routes.LearningGoals));
        Links.Add(new NavigationLink("جاهای مهم", Routes.ImportantPlaces));
        Links.Add(new NavigationLink("بسته‌های آفلاین", Routes.Downloads));
    }


}
