using System.Collections.Generic;

namespace GeoCubed.Minimiez.Application.Features.Teams.GetAllTeams
{
    public class TeamVm
    {
        public TeamVm()
        {
            this.Players = new List<TeamPlayerVm>();
        }

        public string Name { get; set; }

        public bool IsCheckedIn { get; set; }

        public List<TeamPlayerVm> Players { get; set; }
    }
}