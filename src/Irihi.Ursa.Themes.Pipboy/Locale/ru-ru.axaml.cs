using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Irihi.Ursa.Themes.Pipboy.Locale;

public class ru_ru: ResourceDictionary
{
    public ru_ru()
    {
        AvaloniaXamlLoader.Load(this);
        this["STRING_PAGINATION_PAGE"] = string.Empty;
    }
}
