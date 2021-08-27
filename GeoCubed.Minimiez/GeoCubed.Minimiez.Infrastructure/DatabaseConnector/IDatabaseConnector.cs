using System.Data;
using System.Data.Common;

namespace GeoCubed.Minimiez.Infrastructure.DatabaseConnector
{
    public interface IDatabaseConnector
    {
        IDataReader SelectQuery(string query, params object[]? parameters);

        void NonReturnQuery(string query, params object[]? parameters);

        bool TryOpenConnection();

        bool TryCloseConnection();
    }
}
