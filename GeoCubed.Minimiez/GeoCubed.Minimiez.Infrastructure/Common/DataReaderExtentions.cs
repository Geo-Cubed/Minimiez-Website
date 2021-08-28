using System.Data;

namespace GeoCubed.Minimiez.Infrastructure.Common
{
    internal static class DataReaderExtentions
    {
        #region Internal Methods
        /// <summary>
        /// Will try and get the <see cref="string"/> value from the <see cref="IDataReader"/>.
        /// </summary>
        /// <param name="read">The <see cref="IDataReader"/> reader.</param>
        /// <param name="name">The name of the value.</param>
        /// <param name="value">The <see cref="string"/> expected value.</param>
        /// <returns>True if the value is found, false otherwise.</returns>
        internal static bool TryGetValue(this IDataReader read, string name, out string value)
        {
            value = null;
            if (!DoesValueExist(read, name, out int ordinal))
            {
                return false;
            }

            try
            {
                value = read.GetString(ordinal);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Will try and get the <see cref="int"/> value from the <see cref="IDataReader"/>.
        /// </summary>
        /// <param name="read">The <see cref="IDataReader"/> reader.</param>
        /// <param name="name">The name of the value.</param>
        /// <param name="value">The <see cref="int"/> expected value.</param>
        /// <returns>True if the value is found, false otherwise.</returns>
        internal static bool TryGetValue(this IDataReader read, string name, out int value)
        {
            value = int.MinValue;
            if (!DoesValueExist(read, name, out int ordinal))
            {
                return false;
            }

            try
            {
                value = read.GetInt32(ordinal);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Will try and get the <see cref="long"/> value from the <see cref="IDataReader"/>.
        /// </summary>
        /// <param name="read">The <see cref="IDataReader"/> reader.</param>
        /// <param name="name">The name of the value.</param>
        /// <param name="value">The <see cref="long"/> expected value.</param>
        /// <returns>True if the value is found, false otherwise.</returns>
        internal static bool TryGetValue(this IDataReader read, string name, out long value)
        {
            value = long.MinValue;
            if (!DoesValueExist(read, name, out int ordinal))
            {
                return false;
            }

            try
            {
                value = read.GetInt64(ordinal);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Private Methods
        private static bool DoesValueExist(IDataReader read, string name, out int ordinal)
        {
            ordinal = int.MinValue;
            if (string.IsNullOrEmpty(name.Trim()))
            {
                return false;
            }

            if (read.IsClosed)
            {
                return false;
            }

            try
            {
                ordinal = read.GetOrdinal(name);
            }
            catch
            {
                return false;
            }

            if (read.IsDBNull(ordinal))
            {
                return false;
            }

            return true;
        }
        #endregion
    }
}
