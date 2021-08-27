using GeoCubed.Minimiez.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Interfaces
{
    public interface IPlayerRepository : IAsyncRepository
    {
        Task<IReadOnlyList<Participants>> GetAllPlayers();
    }
}
