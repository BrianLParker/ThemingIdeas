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
                    { "class", "text-dark d-flex flex-column" }
                };

            themeDictionary["AppBackground"] = new Dictionary<string, object>
                {
                    { "class", "page" },
                };

            themeDictionary["SideBar"] = new Dictionary<string, object>
                {
                    { "class", "sidebar" }
                };

            themeDictionary["Main"] = new Dictionary<string, object>
                {
                    { "class", "flex-fill d-flex flex-column" }
                };

            themeDictionary["TopRow"] = new Dictionary<string, object>
                {
                    { "class", "top-row px-4" }
                };

            themeDictionary["Content"] = new Dictionary<string, object>
                {
                    { "class", "flex-fill" }
                };

            //"Content" => new Dictionary<string, object>(),
            //"ButtonPrimary" => new Dictionary<string, object>(),
            //"ButtonSecondary" => new Dictionary<string, object>(),
            //"NavigationBar" => new Dictionary<string, object>(),
            //"NavigationItem" => new Dictionary<string, object>()

        }

    }
}
