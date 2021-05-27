using System.Collections.Generic;

namespace ThemingIdeas.Services.Themes
{
    public interface IThemeService
    {
        Dictionary<string, object> this[string theme] { get; }
    }
}
