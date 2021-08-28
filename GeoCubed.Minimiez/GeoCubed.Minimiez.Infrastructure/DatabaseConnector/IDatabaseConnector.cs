using System.Data;
using System.Data.Common;

namespace GeoCubed.Minimiez.Infrastructure.DatabaseConnector
{
    public interface IDatabaseConnector
    {
        /// <summary>
        /// Execute a query that will have a return value such as select.
        /// </summary>
        /// <param name="query">The sql query to execute.</param>
        /// <param name="parameters">The Parameters for the query.</param>
        /// <returns>A <see cref="IDataReader"/> with the results set.</returns>
        IDataReader SelectQuery(string query, params object[]? parameters);

        /// <summary>
        /// Execute a query that does not have a return such as delete.
        /// </summary>
        /// <param name="query">The sql query to execute.</param>
        /// <param name="parameters">The parameters for the query.</param>
        void NonReturnQuery(string query, params object[]? parameters);

        /// <summary>
        /// Will try and open the database connection.
        /// </summary>
        /// <returns>True if the connection opened, false otherwise.</returns>
        bool TryOpenConnection();

        /// <summary>
        /// Will try and close the database connection.
        /// </summary>
        /// <returns>True if the connection closes, false otherwise.</returns>
        bool TryCloseConnection();
    }
}
