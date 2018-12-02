using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldYachts.Properties;

namespace WorldYachts.DAO
{
    class BaseDAO
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(Settings.Default.WorldYachtsConnectionString);
        }
        public static void StoredProcedureCall(string login, string password)
        {
            using (var conn = GetConnection())
            using (var command = new SqlCommand("CheckData", conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                conn.Open();
                command.ExecuteNonQuery();
            }

        }
        public static bool FunctionCall(string login, string password)
        {
            bool a;
            using (var conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT dbo.CheckData(@login,@password)", conn);
                command.Parameters.Add(new SqlParameter("@login", login));
                command.Parameters.Add(new SqlParameter("@password", password));
                var b = command.ExecuteScalar();
                a = Boolean.Parse(b.ToString());
            }
            return a;
        }
    }
}
