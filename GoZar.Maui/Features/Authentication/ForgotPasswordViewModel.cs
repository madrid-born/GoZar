using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Authentication;

public sealed class ForgotPasswordViewModel : BaseViewModel
{
    public ForgotPasswordViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "بازیابی رمز عبور";
        Description = "دسترسی به حسابت را بازیابی کن.";
        TodoMessage = "Connect password recovery; use a neutral response that does not reveal account existence.";
        // TODO : Connect password recovery; use a neutral response that does not reveal account existence.
        Links.Add(new NavigationLink("بازگشت به ورود", Routes.Login));
    }

    private string _email = string.Empty;
    public string Email { get => _email; set => SetProperty(ref _email, value); }
}
