using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Learning;

public sealed class SessionCompleteViewModel : BaseViewModel
{
    public SessionCompleteViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "پایان جلسه";
        Description = "یک قدم آشناتر با شهر.";
        TodoMessage = "Display the actual accepted session summary; do not calculate points, mastery or streaks locally.";
        // TODO : Display the actual accepted session summary; do not calculate points, mastery or streaks locally.
        Links.Add(new NavigationLink("مرور بیشتر", Routes.Reviews));
    }


}
