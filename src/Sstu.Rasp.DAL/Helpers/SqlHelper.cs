using System;
using System.Data;
using System.Data.SqlClient;

namespace Sstu.Rasp.DAL.Helpers
{
    public static class SqlHelper
    {
        public static void AddIdParameter(this SqlCommand command, string parameterName, int value)
        {
            command.Parameters.Add(new SqlParameter 
            {
                ParameterName = parameterName,
                Value = value,
                SqlDbType = SqlDbType.Int,
                IsNullable = false,
                Direction = ParameterDirection.Input
            });
        }

        public static int GetIntValue(this SqlDataReader reader, string name)
        {
            int.TryParse(reader[name].ToString(), out int value);
            return value;
        }

        public static DateTime GetDateValue(this SqlDataReader reader, string name)
        {
            DateTime.TryParse(reader[name].ToString(), out DateTime date);
            return date;
        }

        public static bool GetBoolValue(this SqlDataReader reader, string name)
        {
            bool.TryParse(reader[name].ToString(), out bool result);
            return result;
        }
    }
}