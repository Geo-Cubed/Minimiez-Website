using Microsoft.AspNetCore.Components;

namespace GeoCubed.Minimiez.Website.Shared
{
    public partial class Card
    {
        [Parameter]
        public RenderFragment Headder { get; set; }

        [Parameter]
        public RenderFragment Body { get; set; }

        [Parameter]
        public RenderFragment Footer { get; set; }
    }
}
