using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Irihi.Ursa.Themes.Pipboy.Locale;

public class en_us: ResourceDictionary
{
    public en_us()
    {
        AvaloniaXamlLoader.Load(this);
        this["STRING_PAGINATION_PAGE"] = string.Empty;
    }
}