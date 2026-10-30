using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Profile;

public sealed class ProgressViewModel : BaseViewModel
{
    public ProgressViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "مسیر من";
        Description = "هر روز، آشناتر.";
        TodoMessage = "Load skill summaries and streaks from ProfileApi; distinguish introduced and remembered items.";
        // TODO : Load skill summaries and streaks from ProfileApi; distinguish introduced and remembered items.
        Links.Add(new NavigationLink("تنظیمات", Routes.Settings));
        Links.Add(new NavigationLink("مرورها", Routes.Reviews));
    }


}
