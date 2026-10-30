namespace GoZar.Maui.Services.Storage;
public sealed class PreferencesStore
{
    public string Theme
    {
        get => Preferences.Default.Get("gozar.device-theme", "system");
        set => Preferences.Default.Set("gozar.device-theme", value);
    }
    // TODO : Wire theme changes; decide server versus device settings.
    // Never put credentials or server-authoritative learning progress in Preferences.
}
