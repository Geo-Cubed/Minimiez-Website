using GeoCubed.Minimiez.Application.Interfaces;
using GeoCubed.Minimiez.Domain;
using GeoCubed.Minimiez.Infrastructure.Common;
using GeoCubed.Minimiez.Infrastructure.DatabaseConnector;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Infrastructure.Repositories
{
    public class PlayerRepository : BaseRepository, IPlayerRepository
    {
        public PlayerRepository(IDatabaseConnector connector) : base(connector)
        {
        }

        public Task<IReadOnlyList<Participants>> GetAllPlayers()
        {
            var query = QueryHelper.SelectAllStatement(QueryHelper.Participants);
            var participants = new List<Participants>();
            if (this._connector.TryOpenConnection())
            {
                var read = this._connector.SelectQuery(query);
                while (read.Read())
                {
                    // TODO: Read data into the list.
                }

                this._connector.TryCloseConnection();
            }

            return Task.FromResult((IReadOnlyList<Participants>)participants);
        }
    }
}
