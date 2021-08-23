using GeoCubed.Minimiez.Website.Models.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Website.Pages.Groups
{
    public partial class Groups
    {
        protected List<GroupsViewModel> groups { get; set; }
            = new List<GroupsViewModel>();

        protected override async Task OnInitializedAsync()
        {
            // Get group data.
            var rand = new Random();
            this.groups = new List<GroupsViewModel>()
            {
                new GroupsViewModel()
                {
                    Name = "Pool 1",
                    GroupTeams = new List<GroupTeams>()
                    {
                        new GroupTeams()
                        {
                            TeamName = "Team 1",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 2",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 3",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        }
                    }
                },
                new GroupsViewModel()
                {
                    Name = "Pool 2",
                    GroupTeams = new List<GroupTeams>()
                    {
                        new GroupTeams()
                        {
                            TeamName = "Team 1",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 2",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 3",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        }
                    }
                },
                new GroupsViewModel()
                {
                    Name = "Pool 3",
                    GroupTeams = new List<GroupTeams>()
                    {
                        new GroupTeams()
                        {
                            TeamName = "Team 1",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 2",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 3",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        }
                    }
                },
                new GroupsViewModel()
                {
                    Name = "Pool 4",
                    GroupTeams = new List<GroupTeams>()
                    {
                        new GroupTeams()
                        {
                            TeamName = "Team 1",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 2",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 3",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        }
                    }
                }
            };
        }
    }
}
