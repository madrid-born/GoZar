using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Authentication;

public sealed class VerifyEmailViewModel : BaseViewModel
{
    public VerifyEmailViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "تأیید ایمیل";
        Description = "حسابت را تأیید کن.";
        TodoMessage = "Decide email-link versus code verification and resend/rate-limit behavior.";
        // TODO : Decide email-link versus code verification and resend/rate-limit behavior.

    }

    private string _verificationCode = string.Empty;
    public string VerificationCode { get => _verificationCode; set => SetProperty(ref _verificationCode, value); }
}
