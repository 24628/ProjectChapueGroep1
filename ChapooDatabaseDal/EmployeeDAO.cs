using SomerenDAL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ChapooDatabaseModel;

namespace ChapooDatabaseDal
{
    public class EmployeeDAO : Base
    {
        public List<Employee> GetAllEmployee()
        {
            string query = "SELECT EmployeeID, Firstname, Lastname, Email, Telephone, Position, [Password] FROM Employees";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employeeList = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee menu = new Employee(
                    Convert.ToInt32(dr["EmployeeID"]),
                    dr["Firstname"].ToString(),
                    dr["Lastname"].ToString(),
                    dr["Email"].ToString(),
                    Convert.ToInt32(dr["Telephone"]),
                    dr["Position"].ToString()
                );
                employeeList.Add(menu);
            }
            return employeeList;
        }
    }
}
