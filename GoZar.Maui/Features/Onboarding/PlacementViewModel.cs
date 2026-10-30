using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Onboarding;

public sealed class PlacementViewModel : BaseViewModel
{
    public PlacementViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "آشنایی اولیه";
        Description = "یک شروع مناسب، بدون امتحان سخت.";
        TodoMessage = "Request optional placement questions and let the API decide starting knowledge and onboarding completion.";
        // TODO : Request optional placement questions and let the API decide starting knowledge and onboarding completion.

    }


}
