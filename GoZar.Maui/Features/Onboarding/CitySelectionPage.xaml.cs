namespace GoZar.Maui.Features.Onboarding;

public partial class CitySelectionPage : ContentPage
{
    public CitySelectionPage(CitySelectionViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
