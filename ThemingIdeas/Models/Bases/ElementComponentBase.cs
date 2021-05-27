using Microsoft.AspNetCore.Components;
using ThemingIdeas.Services.Themes;

namespace ThemingIdeas.Models.Bases
{
    public class ElementComponentBase : ComponentBase
    {
        [Parameter]
        public string Theme { get; set; }

        [Inject]
        protected IThemeService ThemeService { get; set; }
    }
}
