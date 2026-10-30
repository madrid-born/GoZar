using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GoZar.Maui.Services.Navigation;

namespace GoZar.Maui.Shared.ViewModels;

public abstract class BaseViewModel : INotifyPropertyChanged
{
    private bool _isBusy;
    private string? _errorMessage;
    protected BaseViewModel(INavigationService navigation)
    {
        NavigateCommand = new Command<string>(async route =>
        {
            if (IsBusy || string.IsNullOrWhiteSpace(route)) return;
            try { IsBusy = true; ErrorMessage = null; await navigation.GoToAsync(route); }
            catch (Exception)
            {
                ErrorMessage = "باز کردن صفحه انجام نشد. دوباره تلاش کن.";
                // TODO : Add structured diagnostics without secrets or personal content.
            }
            finally { IsBusy = false; }
        });
    }
    public string Title { get; protected set; } = string.Empty;
    public string Description { get; protected set; } = string.Empty;
    public string TodoMessage { get; protected set; } = string.Empty;
    public bool IsBusy { get => _isBusy; set => SetProperty(ref _isBusy, value); }
    public string? ErrorMessage { get => _errorMessage; set => SetProperty(ref _errorMessage, value); }
    public ObservableCollection<NavigationLink> Links { get; } = [];
    public ICommand NavigateCommand { get; }
    public event PropertyChangedEventHandler? PropertyChanged;
    protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        return true;
    }
    // TODO : Add page activation/cancellation with the first API-backed feature.
}
public sealed record NavigationLink(string Label, string Route);
