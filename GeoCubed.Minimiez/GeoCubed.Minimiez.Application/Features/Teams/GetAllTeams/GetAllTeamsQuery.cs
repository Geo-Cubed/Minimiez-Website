using MediatR;
using System.Collections.Generic;

namespace GeoCubed.Minimiez.Application.Features.Teams.GetAllTeams
{
    public record GetAllTeamsQuery() : IRequest<List<TeamVm>>;
}