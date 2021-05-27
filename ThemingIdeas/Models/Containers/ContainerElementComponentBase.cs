using Microsoft.AspNetCore.Components;
using ThemingIdeas.Models.Bases;


namespace ThemingIdeas.Models.Containers
{
    public class ContainerElementComponentBase : ElementComponentBase
    {

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
