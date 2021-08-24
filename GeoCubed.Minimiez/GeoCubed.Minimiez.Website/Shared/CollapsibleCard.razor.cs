using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Website.Shared
{
    public partial class CollapsibleCard
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

        protected bool IsCollapsed { get; set; }
            = true;

        protected string CollapsedStyle => this.IsCollapsed ? "collapse" : null;

        protected void ToggleCollapsed()
        {
            this.IsCollapsed = !this.IsCollapsed;
        }
    }
}
