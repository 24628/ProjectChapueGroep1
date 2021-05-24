using SomerenDAL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ChapooDatabaseModel;

namespace ChapooDatabaseDal
{
    public class AuthenticationDAO : Base
    {
        public int CheckUser(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM[Employees] WHERE Email = @email AND[Password] = @password";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            SqlParameter paraemail = new SqlParameter("@email", SqlDbType.VarChar){ Value = email};
            sqlParameters[0] = paraemail;

            SqlParameter paraPassword = new SqlParameter("@password", SqlDbType.VarChar){ Value = password };
            sqlParameters[1] = paraPassword;

            return ExecuteCountInteger(query, sqlParameters);
        }

        public Employee getSingleUser(string email)
        {
            // the query for the database, selecting [type], amount, price, alcohol FROM drinks WHERE amount > 1 AND price > 1.00
            string query = "SELECT EmployeeID, [Firstname], [Lastname], [Email], [Telephone], [Position] FROM Employees WHERE Email = @email";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter paraemail = new SqlParameter("@email", SqlDbType.VarChar){ Value = email };
            sqlParameters[0] = paraemail;

            // return a list with drinks
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private Employee ReadTables(DataTable dataTable)
        {
            Employee emp = new Employee(
                Convert.ToInt32(dataTable.Rows[0]["EmployeeID"]),
                dataTable.Rows[0]["Firstname"].ToString(),
                dataTable.Rows[0]["Lastname"].ToString(),
                dataTable.Rows[0]["Email"].ToString(),
                0643434343,
                dataTable.Rows[0]["Position"].ToString()
            );
            return emp;
        }
    }
}
