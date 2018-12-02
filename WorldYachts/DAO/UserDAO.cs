using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldYachts.DAO
{
    class UserDAO:BaseDAO
    {
        public static User LoginUser(string login, string password)
        {
            using (var connection = GetConnection())
            {
                string sql = @"SELECT  u.Login, u.Password,  FROM dbo.Indentification u 
                WHERE u.Login = @Login AND u.Password = @password;";
                connection.Open();
                var command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@password", password));
                command.Parameters.Add(new SqlParameter("@Login", login));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var user = new User();
          
                    user.login = reader.GetName(0);
                    user.password = reader.GetName(1);
    
                    return user;
                }
                else
                {
                    return null;
                }

            }
        }
    }
}
