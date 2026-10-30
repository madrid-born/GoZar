using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Explore;

public sealed class CityMapViewModel : BaseViewModel
{
    public CityMapViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "نقشه من";
        Description = "شهرِ آشنای تو.";
        TodoMessage = "Choose a renderer and load reviewed geometry plus user progress; preserve attribution and stable context.";
        // TODO : Choose a renderer and load reviewed geometry plus user progress; preserve attribution and stable context.
        Links.Add(new NavigationLink("جزئیات یک مکان", Routes.PlaceDetails));
    }


}
