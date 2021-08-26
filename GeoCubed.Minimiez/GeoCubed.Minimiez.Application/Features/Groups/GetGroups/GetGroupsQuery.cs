using MediatR;
using System.Collections.Generic;

namespace GeoCubed.Minimiez.Application.Features.Groups.GetGroups
{
    public record GetGroupsQuery() : IRequest<List<GroupsVm>>;
}