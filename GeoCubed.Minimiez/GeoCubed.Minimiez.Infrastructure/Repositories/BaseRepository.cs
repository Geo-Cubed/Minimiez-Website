using GeoCubed.Minimiez.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Infrastructure.Repositories
{
    public class BaseRepository : IAsyncRepository
    {
        public BaseRepository()
        {
            // TODO: Database Connection.
        }

        public Task<object> ExecuteCommand(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
