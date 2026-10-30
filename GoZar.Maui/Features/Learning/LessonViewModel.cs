using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Learning;

public sealed class LessonViewModel : BaseViewModel
{
    public LessonViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "آشنایی با یک مکان";
        Description = "اول ببین، بعد به یاد بیاور.";
        TodoMessage = "Load place geometry and teaching content; continuing records introduction, not mastery.";
        // TODO : Load place geometry and teaching content; continuing records introduction, not mastery.
        Links.Add(new NavigationLink("ساختار تمرین", Routes.Exercise));
    }


}
