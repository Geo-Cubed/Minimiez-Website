using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Website.Pages
{
    public partial class Index
    {
        [Inject]
        private NavigationManager navigationManager { get; set; }

        protected void NavigateTo(string url)
        {
            this.navigationManager.NavigateTo(url);
        }
    }
}
