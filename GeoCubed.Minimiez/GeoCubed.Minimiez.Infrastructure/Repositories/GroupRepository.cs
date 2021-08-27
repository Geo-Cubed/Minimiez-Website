using GeoCubed.Minimiez.Application.Interfaces;
using GeoCubed.Minimiez.Domain;
using GeoCubed.Minimiez.Infrastructure.Common;
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
        public Task<IReadOnlyList<Pools>> GetAllGroups()
        {
            var query = QueryHelper.SelectAllStatement(QueryHelper.Pools);

            var data = new List<Pools>();
            // Get Data.

            return Task.FromResult((IReadOnlyList<Pools>)data);
        }
    }
}
