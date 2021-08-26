using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Interfaces
{
    public interface IAsyncRepository
    { 
        // TODO: Chenge to data reader object.
        Task<object> ExecuteCommand(string sql, params object[]? parameters);
    }
}
