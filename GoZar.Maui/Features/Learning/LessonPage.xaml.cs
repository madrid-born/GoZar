namespace GoZar.Maui.Features.Learning;

public partial class LessonPage : ContentPage
{
    public LessonPage(LessonViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
