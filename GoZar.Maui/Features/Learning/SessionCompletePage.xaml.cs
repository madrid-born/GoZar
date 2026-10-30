namespace GoZar.Maui.Features.Learning;

public partial class SessionCompletePage : ContentPage
{
    public SessionCompletePage(SessionCompleteViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
