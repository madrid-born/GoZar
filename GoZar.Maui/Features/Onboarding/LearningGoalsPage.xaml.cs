namespace GoZar.Maui.Features.Onboarding;

public partial class LearningGoalsPage : ContentPage
{
    public LearningGoalsPage(LearningGoalsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
