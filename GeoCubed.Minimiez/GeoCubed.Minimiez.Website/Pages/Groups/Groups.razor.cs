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
            this.groups = new List<GroupsViewModel>()
            {
                new GroupsViewModel()
                {
                    Name = "1",
                    GroupTeams = new List<GroupTeams>()
                    {
                        new GroupTeams()
                        {
                            TeamName = "Team 1",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 2",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 3",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        }
                    }
                },
                new GroupsViewModel()
                {
                    Name = "2",
                    GroupTeams = new List<GroupTeams>()
                    {
                        new GroupTeams()
                        {
                            TeamName = "Team 1",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 2",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 3",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        }
                    }
                },
                new GroupsViewModel()
                {
                    Name = "3",
                    GroupTeams = new List<GroupTeams>()
                    {
                        new GroupTeams()
                        {
                            TeamName = "Team 1",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 2",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 3",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        }
                    }
                },
                new GroupsViewModel()
                {
                    Name = "4",
                    GroupTeams = new List<GroupTeams>()
                    {
                        new GroupTeams()
                        {
                            TeamName = "Team 1",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 2",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        },
                        new GroupTeams()
                        {
                            TeamName = "Team 3",
                            Wins = 1,
                            Loses = 2,
                            Score = 3
                        }
                    }
                }
            };
        }
    }
}
