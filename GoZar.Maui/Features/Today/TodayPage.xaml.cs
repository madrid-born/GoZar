namespace GoZar.Maui.Features.Today;

public partial class TodayPage : ContentPage
{
    public TodayPage(TodayViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
