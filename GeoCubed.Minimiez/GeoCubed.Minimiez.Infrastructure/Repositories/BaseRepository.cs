using GeoCubed.Minimiez.Application.Interfaces;
using GeoCubed.Minimiez.Infrastructure.DatabaseConnector;
using System;

namespace GeoCubed.Minimiez.Infrastructure.Repositories
{
    public class BaseRepository : IAsyncRepository
    {
        protected readonly IDatabaseConnector _connector;

        public BaseRepository(IDatabaseConnector connector)
        {
            if (connector == null)
            {
                throw new ArgumentNullException(nameof(connector));
            }

            this._connector = connector;
        }
    }
}
