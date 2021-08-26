using GeoCubed.Minimiez.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Infrastructure.Repositories
{
    public class GroupRepository : BaseRepository, IGroupRepository
    {
        public GroupRepository() : base()
        {
            // TODO: Dataabse connection stuff.
        }
        public Task<IReadOnlyList<object>> GetAllGroups()
        {
            throw new NotImplementedException();
        }
    }
}
