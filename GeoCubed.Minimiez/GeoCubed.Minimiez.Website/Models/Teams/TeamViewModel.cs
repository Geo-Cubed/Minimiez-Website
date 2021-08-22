using System.Collections.Generic;

namespace GeoCubed.Minimiez.Website.Models.Teams
{
    public class TeamViewModel
    {
        public TeamViewModel()
        {
            this.Players = new List<PlayerViewModel>();
        }

        public string TeamName { get; set; }

        public bool IsCheckedIn { get; set; }

        public IReadOnlyList<PlayerViewModel> Players { get; set; }
    }
}
