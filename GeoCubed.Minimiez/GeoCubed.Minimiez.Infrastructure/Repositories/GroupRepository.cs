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
                    // For some reason the round number is stored as a string in the db so it needs reading in as a str and then parsing to int.
                    data.Add(new Pools()
                    {
                        Round = read.TryGetValue("round", out string round) 
                            ? int.TryParse(round, out int intRound) ? intRound : int.MinValue 
                            : int.MinValue,
                        HomeTeamSeed = read.TryGetValue("team1", out int htSeed) ? htSeed : int.MinValue,
                        AwayTeamSeed = read.TryGetValue("team2", out int atSeed) ? atSeed : int.MinValue,
                        Score = read.TryGetValue("score", out string score) ? score : string.Empty,
                        HomeTeamPath = read.TryGetValue("path1", out string htPath) ? htPath : string.Empty,
                        AwayTeamPath = read.TryGetValue("path2", out string atPath) ? atPath : string.Empty
                    });
                }

                this._connector.TryCloseConnection();
            }

            return Task.FromResult((IReadOnlyList<Pools>)data);
        }
    }
}
