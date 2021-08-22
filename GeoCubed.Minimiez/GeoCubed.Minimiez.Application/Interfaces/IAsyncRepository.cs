using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Interfaces
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
    }
}
