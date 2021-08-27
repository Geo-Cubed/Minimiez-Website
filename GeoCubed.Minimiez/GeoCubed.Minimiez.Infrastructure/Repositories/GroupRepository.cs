using GeoCubed.Minimiez.Application.Interfaces;
using GeoCubed.Minimiez.Domain;
using GeoCubed.Minimiez.Infrastructure.Common;
using GeoCubed.Minimiez.Infrastructure.DatabaseConnector;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Infrastructure.Repositories
{
    public class GroupRepository : BaseRepository, IGroupRepository
    {
        public GroupRepository(IDatabaseConnector connector) : base(connector)
        {
        }

        public Task<IReadOnlyList<Pools>> GetAllGroups()
        {
            var query = QueryHelper.SelectAllStatement(QueryHelper.Pools);
            var data = new List<Pools>();
            if (this._connector.TryOpenConnection())
            {
                var read = this._connector.SelectQuery(query);
                while (read.Read())
                {
                    // TODO: Read data into list.
                }

                this._connector.TryCloseConnection();
            }

            return Task.FromResult((IReadOnlyList<Pools>)data);
        }
    }
}
