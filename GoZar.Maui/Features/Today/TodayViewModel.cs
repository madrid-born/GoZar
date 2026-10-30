using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Today;

public sealed class TodayViewModel : BaseViewModel
{
    public TodayViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "امروز";
        Description = "امروز، شهر را کمی بهتر بشناس.";
        TodoMessage = "Load a resumable recommended session with new content and due reviews.";
        // TODO : Load a resumable recommended session with new content and due reviews.
        Links.Add(new NavigationLink("مسیر یادگیری", Routes.LearningPath));
        Links.Add(new NavigationLink("آشنایی با یک مکان", Routes.Lesson));
        Links.Add(new NavigationLink("مرورهای امروز", Routes.Reviews));
    }


}
