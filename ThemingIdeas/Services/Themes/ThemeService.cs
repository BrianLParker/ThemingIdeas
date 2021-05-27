using System;
using System.Collections.Generic;
using System.Linq;

namespace ThemingIdeas.Services.Themes
{
    public class ThemeService : IThemeService
    {
        private readonly Dictionary<string, Dictionary<string, object>> themeDictionary;

        public ThemeService()
        {
            themeDictionary = new Dictionary<string, Dictionary<string, object>>();
            LoadThemeDefaults();
        }

        public Dictionary<string, object> this[string theme] => themeDictionary[theme];

        private void LoadThemeDefaults()
        {
            themeDictionary["Background"] = new Dictionary<string, object>
                {
                    { "class", "text-dark" },
                    { "style", "background-color: orange" }
                };

            //"Content" => new Dictionary<string, object>(),
            //"ButtonPrimary" => new Dictionary<string, object>(),
            //"ButtonSecondary" => new Dictionary<string, object>(),
            //"NavigationBar" => new Dictionary<string, object>(),
            //"NavigationItem" => new Dictionary<string, object>()

        }

    }
}
