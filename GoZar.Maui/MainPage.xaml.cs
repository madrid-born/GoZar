namespace GoZar.Maui;

public partial class MainPage : ContentPage
{
    int count;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Cligvregcked {count} time";
        else
            CounterBtn.Text = $"Clickdwdwded {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}