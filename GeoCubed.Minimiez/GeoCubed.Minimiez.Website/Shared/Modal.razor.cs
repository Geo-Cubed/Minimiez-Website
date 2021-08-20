using Microsoft.AspNetCore.Components;

namespace GeoCubed.Minimiez.Website.Shared
{
    public partial class Modal
    {
        [Parameter]
        public RenderFragment Title { get; set; }

        [Parameter]
        public RenderFragment Body { get; set; }

        [Parameter]
        public RenderFragment Footer { get; set; }

        private string _modalDisplay = "none;";
        private string _modalClass = "";
        private bool _showBackdrop = false;

        public void Open()
        {
            this._modalDisplay = "block;";
            this._modalClass = "show";
            this._showBackdrop = true;
        }

        public void Close()
        {
            this._modalDisplay = "none";
            this._modalClass = "";
            this._showBackdrop = false;
        }
    }
}
