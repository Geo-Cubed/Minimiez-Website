using System.Collections.Generic;

namespace GeoCubed.Minimiez.Application.Features.Groups.GetGroups
{
    public class GroupsVm
    {
        public GroupsVm()
        {
            this.Teams = new List<GroupTeamVm>();
        }

        public string Name { get; set; }

        public List<GroupTeamVm> Teams { get; set; }
    }
}