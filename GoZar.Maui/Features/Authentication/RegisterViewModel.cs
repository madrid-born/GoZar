using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Authentication;

public sealed class RegisterViewModel : BaseViewModel
{
    public RegisterViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "ساخت حساب";
        Description = "آغاز شناخت شهر، با حساب خودت.";
        TodoMessage = "Decide registration fields, consent and verification requirements with the API.";
        // TODO : Decide registration fields, consent and verification requirements with the API.
        Links.Add(new NavigationLink("قبلاً حساب دارم", Routes.Login));
    }

    private string _email = string.Empty;
    public string Email { get => _email; set => SetProperty(ref _email, value); }
    private string _password = string.Empty;
    public string Password { get => _password; set => SetProperty(ref _password, value); }
    private string _confirmPassword = string.Empty;
    public string ConfirmPassword { get => _confirmPassword; set => SetProperty(ref _confirmPassword, value); }
}
