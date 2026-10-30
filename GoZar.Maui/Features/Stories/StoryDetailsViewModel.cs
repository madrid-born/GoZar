using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Stories;

public sealed class StoryDetailsViewModel : BaseViewModel
{
    public StoryDetailsViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "قصه یک مکان";
        Description = "یک قصه، یک جای ماندگار.";
        TodoMessage = "Load reviewed story content by ID; display source references and related places.";
        // TODO : Load reviewed story content by ID; display source references and related places.
        Links.Add(new NavigationLink("ساختار جزئیات مکان", Routes.PlaceDetails));
    }


}
