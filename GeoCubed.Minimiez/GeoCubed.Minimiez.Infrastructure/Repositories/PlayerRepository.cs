using GeoCubed.Minimiez.Application.Interfaces;
using GeoCubed.Minimiez.Domain;
using GeoCubed.Minimiez.Infrastructure.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Infrastructure.Repositories
{
    public class PlayerRepository : BaseRepository, IPlayerRepository
    {
        public PlayerRepository() : base()
        {
            // TODO: Database stuff.
        }
        public Task<IReadOnlyList<Participants>> GetAllPlayers()
        {
            var query = QueryHelper.SelectAllStatement(QueryHelper.Participants);

            var participants = new List<Participants>();
            // Database read.

            return Task.FromResult((IReadOnlyList<Participants>)participants);
        }
    }
}
