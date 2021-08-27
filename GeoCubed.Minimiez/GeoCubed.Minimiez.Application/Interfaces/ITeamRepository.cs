using GeoCubed.Minimiez.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Interfaces
{
    public interface ITeamRepository : IAsyncRepository
    {
        Task<IReadOnlyList<Teams>> GetAllTeams();
    }
}
