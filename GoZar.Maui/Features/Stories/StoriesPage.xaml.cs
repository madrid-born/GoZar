namespace GoZar.Maui.Features.Stories;

public partial class StoriesPage : ContentPage
{
    public StoriesPage(StoriesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
