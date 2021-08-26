using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Interfaces
{
    public interface IGroupRepository : IAsyncRepository // TODO: USE GROUPS ENTITY.
    {
        Task<IReadOnlyList<object>> GetAllGroups();
    }
}
