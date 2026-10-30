using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Explore;

public sealed class PlaceDetailsViewModel : BaseViewModel
{
    public PlaceDetailsViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "جزئیات مکان";
        Description = "هر جا، چند ارتباط تازه.";
        TodoMessage = "Load a place by ID with aliases, relationships and skill progress.";
        // TODO : Load a place by ID with aliases, relationships and skill progress.
        Links.Add(new NavigationLink("دیدن ساختار درس", Routes.Lesson));
        Links.Add(new NavigationLink("دیدن ساختار تمرین", Routes.Exercise));
    }


}
