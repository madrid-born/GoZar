namespace GoZar.Maui.Features.Reviews;

public partial class ReviewsPage : ContentPage
{
    public ReviewsPage(ReviewsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
