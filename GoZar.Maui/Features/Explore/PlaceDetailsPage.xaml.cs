namespace GoZar.Maui.Features.Explore;

public partial class PlaceDetailsPage : ContentPage
{
    public PlaceDetailsPage(PlaceDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
