namespace GoZar.Maui.Features.Learning;

public partial class LearningPathPage : ContentPage
{
    public LearningPathPage(LearningPathViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
