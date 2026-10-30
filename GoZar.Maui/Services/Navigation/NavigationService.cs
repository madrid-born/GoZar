namespace GoZar.Maui.Services.Navigation;

public sealed class NavigationService : INavigationService
{
    public Task GoToAsync(string route) => MainThread.InvokeOnMainThreadAsync(async () =>
    {
        var shell = Shell.Current ?? throw new InvalidOperationException("The app shell is not ready.");
        if (shell is AppShell appShell)
        {
            if (route.StartsWith("//main/", StringComparison.Ordinal)) appShell.ShowMainTabs();
            else if (route == Routes.Welcome) appShell.ShowAuthentication();
        }
        // TODO : Enforce restored-session routing when authentication is wired. API endpoints authorize independently.
        await shell.GoToAsync(route);
    });
    public Task GoBackAsync() => MainThread.InvokeOnMainThreadAsync(async () =>
    {
        var shell = Shell.Current;
        if (shell?.Navigation.NavigationStack.Count > 1) await shell.GoToAsync("..");
    });
}
