using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Onboarding;

public sealed class LearningGoalsViewModel : BaseViewModel
{
    public LearningGoalsViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "علاقه‌های یادگیری";
        Description = "چه چیزی برایت جذاب‌تر است؟";
        TodoMessage = "Load available goals and save selections through ProfileApi.";
        // TODO : Load available goals and save selections through ProfileApi.
        Links.Add(new NavigationLink("جاهای مهم من", Routes.ImportantPlaces));
    }


}
