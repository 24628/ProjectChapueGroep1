using SomerenDAL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ChapooDatabaseDal
{
    public class AuthenticationDAO : Base
    {
        public int CheckUser(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM[user] WHERE email = @email AND[password] = @password";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            SqlParameter paraemail = new SqlParameter("@email", SqlDbType.VarChar);
            paraemail.Value = email;
            sqlParameters[0] = paraemail;

            SqlParameter paraPassword = new SqlParameter("@password", SqlDbType.VarChar);
            paraPassword.Value = password;
            sqlParameters[1] = paraPassword;

            return ExecuteCountInteger(query, sqlParameters);
        }
    }
}
