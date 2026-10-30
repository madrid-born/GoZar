namespace GoZar.Maui.Services.Navigation;
public interface INavigationService
{
    Task GoToAsync(string route);
    Task GoBackAsync();
}
