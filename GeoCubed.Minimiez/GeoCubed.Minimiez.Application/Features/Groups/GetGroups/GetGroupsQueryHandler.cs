using AutoMapper;
using GeoCubed.Minimiez.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Features.Groups.GetGroups
{
    public class GetGroupsQueryHandler : IRequestHandler<GetGroupsQuery, List<GroupsVm>>
    {
        private readonly IMapper _mapper;
        private readonly IGroupRepository _groupRepository;

        public GetGroupsQueryHandler(IMapper mapper, IGroupRepository groupRepository)
        {
            this._mapper = mapper;
            this._groupRepository = groupRepository;
        }

        public async Task<List<GroupsVm>> Handle(GetGroupsQuery request, CancellationToken cancellationToken)
        {
            // TODO: Replace dummy data with real data
            var rand = new Random();
            var groups = new List<GroupsVm>()
            {
                new GroupsVm()
                {
                    Name = "Pool 1",
                    Teams = new List<GroupTeamVm>()
                    {
                        new GroupTeamVm()
                        {
                            Name = "Team 1",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeamVm()
                        {
                            Name = "Team 2",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeamVm()
                        {
                            Name = "Team 3",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        }
                    }
                },
                new GroupsVm()
                {
                    Name = "Pool 2",
                    Teams = new List<GroupTeamVm>()
                    {
                        new GroupTeamVm()
                        {
                            Name = "Team 1",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeamVm()
                        {
                            Name = "Team 2",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeamVm()
                        {
                            Name = "Team 3",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        }
                    }
                },
                new GroupsVm()
                {
                    Name = "Pool 3",
                    Teams = new List<GroupTeamVm>()
                    {
                        new GroupTeamVm()
                        {
                            Name = "Team 1",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeamVm()
                        {
                            Name = "Team 2",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeamVm()
                        {
                            Name = "Team 3",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        }
                    }
                },
                new GroupsVm()
                {
                    Name = "Pool 4",
                    Teams = new List<GroupTeamVm>()
                    {
                        new GroupTeamVm()
                        {
                            Name = "Team 1",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeamVm()
                        {
                            Name = "Team 2",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        },
                        new GroupTeamVm()
                        {
                            Name = "Team 3",
                            Wins = rand.Next(0, 5),
                            Loses = rand.Next(0, 5),
                            Score = rand.Next(5, 25)
                        }
                    }
                }
            };

            return groups;
        }
    }
}
