using System.Windows.Input;
using GoZar.Maui.Shared.ViewModels;

namespace GoZar.Maui.Shared.Controls;

/// <summary>Temporary shell. Replace feature content one page at a time.</summary>
public partial class ScaffoldView : ContentView
{
    public ScaffoldView() => InitializeComponent();

    public ICommand? NavigationCommand => (BindingContext as BaseViewModel)?.NavigateCommand;

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        OnPropertyChanged(nameof(NavigationCommand));
    }
}
