using GeoCubed.Minimiez.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Interfaces
{
    public interface IGroupRepository : IAsyncRepository
    {
        Task<IReadOnlyList<Pools>> GetAllGroups();
    }
}
