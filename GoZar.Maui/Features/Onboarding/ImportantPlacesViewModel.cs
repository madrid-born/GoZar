using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Onboarding;

public sealed class ImportantPlacesViewModel : BaseViewModel
{
    public ImportantPlacesViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "جاهای مهم من";
        Description = "از جاهای آشنا شروع کنیم.";
        TodoMessage = "Resolve approximate public places; keep personal relevance separate from prior knowledge.";
        // TODO : Resolve approximate public places; keep personal relevance separate from prior knowledge.
        Links.Add(new NavigationLink("بررسی آشنایی اولیه", Routes.Placement));
    }


}
