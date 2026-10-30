namespace GoZar.Maui.Features.Onboarding;

public partial class PlacementPage : ContentPage
{
    public PlacementPage(PlacementViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
