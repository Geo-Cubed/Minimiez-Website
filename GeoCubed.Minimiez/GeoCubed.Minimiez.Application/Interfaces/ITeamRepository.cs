using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Interfaces
{
    public interface ITeamRepository : IAsyncRepository // TODO: USE TEAM ENTITY.
    {
        Task<IReadOnlyList<object>> GetAllTeamsWithPlayers();
    }
}
