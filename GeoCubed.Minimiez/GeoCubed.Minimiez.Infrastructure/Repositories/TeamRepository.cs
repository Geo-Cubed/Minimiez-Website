using GeoCubed.Minimiez.Application.Interfaces;
using GeoCubed.Minimiez.Domain;
using GeoCubed.Minimiez.Infrastructure.Common;
using GeoCubed.Minimiez.Infrastructure.DatabaseConnector;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Infrastructure.Repositories
{
    public class TeamRepository : BaseRepository, ITeamRepository
    {
        public TeamRepository(IDatabaseConnector connector) : base(connector)
        {
        }

        public Task<IReadOnlyList<Teams>> GetAllTeams()
        {
            var query = QueryHelper.SelectAllStatement(QueryHelper.Teams);
            var data = new List<Teams>();
            if (this._connector.TryOpenConnection())
            {
                var read = this._connector.SelectQuery(query);
                while (read.Read())
                {
                    // TODO: Read data into list.
                }

                this._connector.TryCloseConnection();
            }

            return Task.FromResult((IReadOnlyList<Teams>)data);
        }
    }
}
