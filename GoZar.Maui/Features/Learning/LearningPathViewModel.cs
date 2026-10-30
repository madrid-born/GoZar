using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Learning;

public sealed class LearningPathViewModel : BaseViewModel
{
    public LearningPathViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "مسیر یادگیری";
        Description = "جاها را به هم وصل کن.";
        TodoMessage = "Load chapters, prerequisites and lesson progress from LearningApi.";
        // TODO : Load chapters, prerequisites and lesson progress from LearningApi.
        Links.Add(new NavigationLink("دیدن ساختار یک درس", Routes.Lesson));
    }


}
