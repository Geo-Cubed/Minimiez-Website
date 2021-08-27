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
            // General idea is to have an IDatabaseConnector that is passed in the constructor
            // This connector will contain the logic to call the database, and means I can switch
            // out for another if needed.
        }
    }
}
