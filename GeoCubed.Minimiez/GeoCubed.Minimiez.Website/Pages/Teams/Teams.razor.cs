using GeoCubed.Minimiez.Website.Models.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Website.Pages.Teams
{
    public partial class Teams
    {
        protected List<TeamViewModel> Participants { get; set; }
            = new List<TeamViewModel>();

        protected override async Task OnInitializedAsync()
        {
            // Get team data.
            var rand = new Random();
            this.Participants = new List<TeamViewModel>()
            {
                new TeamViewModel()
                {
                    TeamName = "Team 1",
                    IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                    Players = new List<PlayerViewModel>()
                    {
                        new PlayerViewModel()
                        {
                            Name = "Player 1",
                            IsCaptain = true,
                            IsCheckedIn = true,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 2",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 3",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 4",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        }
                    }
                },
                new TeamViewModel()
                {
                    TeamName = "Team 2",
                    IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                    Players = new List<PlayerViewModel>()
                    {
                        new PlayerViewModel()
                        {
                            Name = "Player 1",
                            IsCaptain = true,
                            IsCheckedIn = true,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 2",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 3",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 4",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        }
                    }
                },
                new TeamViewModel()
                {
                    TeamName = "Team 3",
                    IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                    Players = new List<PlayerViewModel>()
                    {
                        new PlayerViewModel()
                        {
                            Name = "Player 1",
                            IsCaptain = true,
                            IsCheckedIn = true,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 2",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 3",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 4",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        }
                    }
                },
                new TeamViewModel()
                {
                    TeamName = "Team 4",
                    IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                    Players = new List<PlayerViewModel>()
                    {
                        new PlayerViewModel()
                        {
                            Name = "Player 1",
                            IsCaptain = true,
                            IsCheckedIn = true,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 2",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 3",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new PlayerViewModel()
                        {
                            Name = "Player 4",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        }
                    }
                }
            };
        }
    }
}
