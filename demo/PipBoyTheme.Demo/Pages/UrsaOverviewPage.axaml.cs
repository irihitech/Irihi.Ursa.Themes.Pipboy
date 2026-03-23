using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Ursa.Controls;

namespace PipboyTheme.Demo.Pages;

public partial class UrsaOverviewPage : UserControl
{
    public UrsaOverviewPage()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        MessageBox.ShowOverlayAsync("Hello World");
    }
}