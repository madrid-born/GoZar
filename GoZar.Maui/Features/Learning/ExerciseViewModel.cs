using GoZar.Maui.Services.Navigation;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Features.Learning;

public sealed class ExerciseViewModel : BaseViewModel
{
    public ExerciseViewModel(INavigationService navigation) : base(navigation)
    {
        Title = "تمرین";
        Description = "دانسته‌هایت را به یاد بیاور.";
        TodoMessage = "Load the active server question and bind the matching exercise view; submit answers idempotently.";
        // TODO : Load the active server question and bind the matching exercise view; submit answers idempotently.

    }


}
