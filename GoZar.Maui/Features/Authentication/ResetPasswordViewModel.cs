using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Authentication;

public sealed class ResetPasswordViewModel : BaseViewModel
{
    public ResetPasswordViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "رمز عبور تازه";
        Description = "یک رمز عبور تازه انتخاب کن.";
        TodoMessage = "Handle the validated recovery link/code and password policy from the API.";
        // TODO : Handle the validated recovery link/code and password policy from the API.
        Links.Add(new NavigationLink("بازگشت به ورود", Routes.Login));
    }

    private string _password = string.Empty;
    public string Password { get => _password; set => SetProperty(ref _password, value); }
    private string _confirmPassword = string.Empty;
    public string ConfirmPassword { get => _confirmPassword; set => SetProperty(ref _confirmPassword, value); }
}
