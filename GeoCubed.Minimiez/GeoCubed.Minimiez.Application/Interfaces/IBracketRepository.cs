using GeoCubed.Minimiez.Domain;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Interfaces
{
    interface IBracketRepository : IAsyncRepository
    {
        Task<PlayAllPlacements> GetAllBracket();
    }
}
