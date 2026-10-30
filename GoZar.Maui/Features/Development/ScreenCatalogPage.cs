#if DEBUG
using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.Controls;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Development;

public sealed class ScreenCatalogPage : ContentPage
{
    public ScreenCatalogPage(INavigationService navigation)
    {
        Title = "فهرست صفحه‌ها · توسعه";
        FlowDirection = FlowDirection.RightToLeft;
        BindingContext = new ScreenCatalogViewModel(navigation);
        Content = new ScrollView { Content = new ScaffoldView() };
    }
}

public sealed class ScreenCatalogViewModel : BaseViewModel
{
    public ScreenCatalogViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "فهرست صفحه‌ها · فقط توسعه";
        Description = "این فهرست برای بررسی ساختار است؛ ورود واقعی انجام نشده است.";
        TodoMessage = "Connect session restoration and authenticated routing before shipping API-backed features.";
        Links.Add(new NavigationLink("ورود", Routes.Login));
        Links.Add(new NavigationLink("ساخت حساب", Routes.Register));
        Links.Add(new NavigationLink("تأیید ایمیل", Routes.VerifyEmail));
        Links.Add(new NavigationLink("بازیابی رمز عبور", Routes.ForgotPassword));
        Links.Add(new NavigationLink("رمز عبور تازه", Routes.ResetPassword));
        Links.Add(new NavigationLink("انتخاب شهر", Routes.CitySelection));
        Links.Add(new NavigationLink("علاقه‌های یادگیری", Routes.LearningGoals));
        Links.Add(new NavigationLink("جاهای مهم من", Routes.ImportantPlaces));
        Links.Add(new NavigationLink("آشنایی اولیه", Routes.Placement));
        Links.Add(new NavigationLink("امروز", Routes.Today));
        Links.Add(new NavigationLink("مسیر یادگیری", Routes.LearningPath));
        Links.Add(new NavigationLink("آشنایی با یک مکان", Routes.Lesson));
        Links.Add(new NavigationLink("تمرین", Routes.Exercise));
        Links.Add(new NavigationLink("پایان جلسه", Routes.SessionComplete));
        Links.Add(new NavigationLink("نقشه من", Routes.CityMap));
        Links.Add(new NavigationLink("جزئیات مکان", Routes.PlaceDetails));
        Links.Add(new NavigationLink("مرورهای امروز", Routes.Reviews));
        Links.Add(new NavigationLink("کشف شهر", Routes.Stories));
        Links.Add(new NavigationLink("قصه یک مکان", Routes.StoryDetails));
        Links.Add(new NavigationLink("مسیر من", Routes.Progress));
        Links.Add(new NavigationLink("تنظیمات", Routes.Settings));
        Links.Add(new NavigationLink("بسته‌های آفلاین", Routes.Downloads));
    }
}
#endif
