namespace GoZar.Maui.Features.Explore;

public partial class CityMapPage : ContentPage
{
    public CityMapPage(CityMapViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
