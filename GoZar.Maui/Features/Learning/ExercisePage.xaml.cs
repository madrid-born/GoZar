namespace GoZar.Maui.Features.Learning;

public partial class ExercisePage : ContentPage
{
    public ExercisePage(ExerciseViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
