namespace GoZar.Maui.Features.Profile;

public partial class DownloadsPage : ContentPage
{
    public DownloadsPage(DownloadsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
