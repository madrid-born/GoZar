namespace GoZar.Maui.Features.Profile;

public partial class ProgressPage : ContentPage
{
    public ProgressPage(ProgressViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
