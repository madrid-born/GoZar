namespace GoZar.Maui.Features.Stories;

public partial class StoryDetailsPage : ContentPage
{
    public StoryDetailsPage(StoryDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
