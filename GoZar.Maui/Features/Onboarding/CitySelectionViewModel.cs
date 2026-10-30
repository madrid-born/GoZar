using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Onboarding;

public sealed class CitySelectionViewModel : BaseViewModel
{
    public CitySelectionViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "انتخاب شهر";
        Description = "کدام شهر را کشف کنیم؟";
        TodoMessage = "Load published cities from CatalogApi and persist the selected city through the API.";
        // TODO : Load published cities from CatalogApi and persist the selected city through the API.
        Links.Add(new NavigationLink("علاقه‌های یادگیری", Routes.LearningGoals));
    }


}
