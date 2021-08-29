using Microsoft.AspNetCore.Components;

namespace GeoCubed.Minimiez.Website.Shared
{
    public partial class Card
    {
        [Parameter]
        public RenderFragment Header { get; set; }

        [Parameter]
        public RenderFragment Body { get; set; }

        [Parameter]
        public RenderFragment Footer { get; set; }

        [Parameter]
        public string ClassStyle { get; set; }

        [Parameter]
        public string ExtraStyles { get; set; }

        [Parameter]
        public string ClickUrl { get; set; }

        [Inject]
        private NavigationManager Navigation { get; set; }

        protected void NavigateTo()
        {
            if (!string.IsNullOrEmpty(this.ClickUrl))
            {
                this.Navigation.NavigateTo(this.ClickUrl);
            }
        }
    }
}
