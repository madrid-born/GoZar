using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Authentication;

public sealed class LoginViewModel : BaseViewModel
{
    public LoginViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "ورود";
        Description = "به مسیر یادگیری‌ات برگرد.";
        TodoMessage = "Connect login to the decided authentication contract; never simulate successful login.";
        // TODO : Connect login to the decided authentication contract; never simulate successful login.
        Links.Add(new NavigationLink("فراموشی رمز عبور", Routes.ForgotPassword));
        Links.Add(new NavigationLink("ساخت حساب", Routes.Register));
    }

    private string _email = string.Empty;
    public string Email { get => _email; set => SetProperty(ref _email, value); }
    private string _password = string.Empty;
    public string Password { get => _password; set => SetProperty(ref _password, value); }
}
