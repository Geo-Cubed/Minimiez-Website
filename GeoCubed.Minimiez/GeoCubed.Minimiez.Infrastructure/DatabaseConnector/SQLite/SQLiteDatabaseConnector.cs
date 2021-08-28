using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;

namespace GeoCubed.Minimiez.Infrastructure.DatabaseConnector.SQLite
{
    internal class SQLiteDatabaseConnector : IDatabaseConnector
    {
        private readonly string _connectionStr;
        private DbConnection _connection;

        #region Constructor
        public SQLiteDatabaseConnector(string connectionStr)
        {
            this._connectionStr = connectionStr;
        }
        #endregion

        #region Public Members
        /// <summary>
        /// Execute a query that does not have a return such as delete.
        /// </summary>
        /// <param name="query">The sql query to execute.</param>
        /// <param name="parameters">The parameters for the query.</param>
        public void NonReturnQuery(string query, params object?[] parameters)
        {
            if (string.IsNullOrEmpty(query.Trim()))
            {
                throw new ArgumentNullException(nameof(query));
            }

            var cmd = new SQLiteCommand(query, (SQLiteConnection)this._connection);
            if (parameters != null && parameters.Any())
            {
                this.LoadParameters(ref cmd, parameters);
            }

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Execute a query that will have a return value such as select.
        /// </summary>
        /// <param name="query">The sql query to execute.</param>
        /// <param name="parameters">The Parameters for the query.</param>
        /// <returns>A <see cref="IDataReader"/> with the results set.</returns>
        public IDataReader SelectQuery(string query, params object?[] parameters)
        {
            if (string.IsNullOrEmpty(query.Trim()))
            {
                throw new ArgumentNullException(nameof(query));
            }

            var cmd = new SQLiteCommand(query, (SQLiteConnection)this._connection);
            if (parameters != null && parameters.Any())
            {
                this.LoadParameters(ref cmd, parameters);
            }

            return cmd.ExecuteReader();
        }

        /// <summary>
        /// Will try and open the database connection.
        /// </summary>
        /// <returns>True if the connection opened, false otherwise.</returns>
        public bool TryOpenConnection()
        {
            var result = true;
            try
            {
                // Open Connection.
                this._connection = new SQLiteConnection(this._connectionStr);
                this._connection.Open();
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Will try and close the database connection.
        /// </summary>
        /// <returns>True if the connection closes, false otherwise.</returns>
        public bool TryCloseConnection()
        {
            var result = true;
            try
            {
                // Close Connection.
                this._connection.Close();
            }
            catch
            {
                result = false;
            }

            return result;
        }
        #endregion

        #region Private Members
        private void LoadParameters(ref SQLiteCommand command, params object[] parameters)
        {
            var counter = 1;
            foreach (var item in parameters)
            {
                command.Parameters.Add(new SQLiteParameter($"@param_{counter}", item));
                ++counter;
            }
        }
        #endregion
    }
}
