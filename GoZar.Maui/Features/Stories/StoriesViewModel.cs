using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Stories;

public sealed class StoriesViewModel : BaseViewModel
{
    public StoriesViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "کشف شهر";
        Description = "پشت هر جا، یک قصه است.";
        TodoMessage = "Load published editorial content and source metadata from StoriesApi.";
        // TODO : Load published editorial content and source metadata from StoriesApi.
        Links.Add(new NavigationLink("جزئیات یک داستان", Routes.StoryDetails));
    }


}
