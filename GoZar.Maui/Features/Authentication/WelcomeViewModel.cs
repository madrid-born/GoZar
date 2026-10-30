using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Authentication;

public sealed class WelcomeViewModel : BaseViewModel
{
    public WelcomeViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "به گذر خوش آمدی";
        Description = "هر روز، یک قدم آشناتر با شهر.";
        TodoMessage = "Choose the startup destination after restoring a real API session.";
        // TODO : Choose the startup destination after restoring a real API session.
        Links.Add(new NavigationLink("ورود", Routes.Login));
        Links.Add(new NavigationLink("ساخت حساب", Routes.Register));
#if DEBUG
        Links.Add(new NavigationLink("فهرست صفحه‌ها · فقط توسعه", Routes.ScreenCatalog));
#endif
    }


}
