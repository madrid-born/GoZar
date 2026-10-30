using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Profile;

public sealed class DownloadsViewModel : BaseViewModel
{
    public DownloadsViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "بسته‌های آفلاین";
        Description = "شهر را همراه خودت داشته باش.";
        TodoMessage = "Decide versioned download manifests, local storage, cancellation and retry before implementing offline content.";
        // TODO : Decide versioned download manifests, local storage, cancellation and retry before implementing offline content.

    }


}
