using GeoCubed.Minimiez.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Infrastructure.Repositories
{
    public class TeamRepository : BaseRepository, ITeamRepository
    {
        public TeamRepository() : base()
        {
            // TODO: Database stuff.
        }

        public Task<IReadOnlyList<object>> GetAllTeamsWithPlayers()
        {
            throw new NotImplementedException();
        }
    }
}
