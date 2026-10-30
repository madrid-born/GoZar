namespace GoZar.Maui;

public partial class App : Application
{
    private readonly AppShell _shell;

    public App(AppShell shell)
    {
        InitializeComponent();
        _shell = shell;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // TODO : Restore a validated API session before selecting onboarding or main tabs.
        return new Window(_shell) { Title = "GoZar" };
    }
}