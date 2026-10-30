using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Reviews;

public sealed class ReviewsViewModel : BaseViewModel
{
    public ReviewsViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "مرورهای امروز";
        Description = "کمتر بخوان، بیشتر به یاد بیاور.";
        TodoMessage = "Request due reviews from the API separately from relevance-ranked new content.";
        // TODO : Request due reviews from the API separately from relevance-ranked new content.
        Links.Add(new NavigationLink("ساختار تمرین مرور", Routes.Exercise));
    }


}
