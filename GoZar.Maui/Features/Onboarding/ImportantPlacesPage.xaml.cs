namespace GoZar.Maui.Features.Onboarding;

public partial class ImportantPlacesPage : ContentPage
{
    public ImportantPlacesPage(ImportantPlacesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
