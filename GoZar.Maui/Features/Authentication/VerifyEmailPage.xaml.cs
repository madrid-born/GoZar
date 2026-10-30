namespace GoZar.Maui.Features.Authentication;

public partial class VerifyEmailPage : ContentPage
{
    public VerifyEmailPage(VerifyEmailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
