using AutoMapper;
using GeoCubed.Minimiez.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Features.Teams.GetAllTeams
{
    public class GetAllTeamsQueryHandler : IRequestHandler<GetAllTeamsQuery, List<TeamVm>>
    {
        private readonly IMapper _mapper;
        private readonly ITeamRepository _teamRepository;

        public GetAllTeamsQueryHandler(IMapper mapper, ITeamRepository teamRepository)
        {
            this._mapper = mapper;
            this._teamRepository = teamRepository;
        }

        public async Task<List<TeamVm>> Handle(GetAllTeamsQuery request, CancellationToken cancellationToken)
        {
            var rand = new Random();
            var teams = new List<TeamVm>()
            {
                new TeamVm()
                {
                    Name = "Team 1",
                    IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                    Players = new List<TeamPlayerVm>()
                    {
                        new TeamPlayerVm()
                        {
                            Name = "Player 1",
                            IsCaptain = true,
                            IsCheckedIn = true,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 2",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 3",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 4",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        }
                    }
                },
                new TeamVm()
                {
                    Name = "Team 2",
                    IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                    Players = new List<TeamPlayerVm>()
                    {
                        new TeamPlayerVm()
                        {
                            Name = "Player 1",
                            IsCaptain = true,
                            IsCheckedIn = true,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 2",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 3",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 4",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        }
                    }
                },
                new TeamVm()
                {
                    Name = "Team 3",
                    IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                    Players = new List<TeamPlayerVm>()
                    {
                        new TeamPlayerVm()
                        {
                            Name = "Player 1",
                            IsCaptain = true,
                            IsCheckedIn = true,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 2",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 3",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 4",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        }
                    }
                },
                new TeamVm()
                {
                    Name = "Team 4",
                    IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                    Players = new List<TeamPlayerVm>()
                    {
                        new TeamPlayerVm()
                        {
                            Name = "Player 1",
                            IsCaptain = true,
                            IsCheckedIn = true,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 2",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 3",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        },
                        new TeamPlayerVm()
                        {
                            Name = "Player 4",
                            IsCaptain = false,
                            IsCheckedIn = (rand.Next(0,1) == 1) ? true : false,
                            IsConfirmed = true
                        }
                    }
                }
            };

            return teams;
        }
    }
}
