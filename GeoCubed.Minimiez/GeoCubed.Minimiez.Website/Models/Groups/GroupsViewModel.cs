using System.Collections.Generic;

namespace GeoCubed.Minimiez.Website.Models.Groups
{
    public class GroupsViewModel
    {
        public GroupsViewModel()
        {
            this.GroupTeams = new List<GroupTeams>();
        }

        public string Name { get; set; }

        public IReadOnlyList<GroupTeams> GroupTeams { get; set; }
    }
}
