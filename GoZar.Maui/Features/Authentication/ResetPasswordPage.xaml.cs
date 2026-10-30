namespace GoZar.Maui.Features.Authentication;

public partial class ResetPasswordPage : ContentPage
{
    public ResetPasswordPage(ResetPasswordViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
