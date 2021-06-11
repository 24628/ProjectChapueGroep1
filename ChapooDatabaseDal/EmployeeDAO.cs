using SomerenDAL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateEmploy(int EmployeeID, string Firstname, string Lastname, string Email, int Telephone, string Position)
        {
            string query = $"Update Employees set  Employees.EmployeeID = '{EmployeeID}', Employees.Firstname = {Firstname}, Employees.Lastname = '{Lastname}', Employees.Email = '{Email}', Employees.Telephone = '{Telephone}', Employees.Position = '{Position}' WHERE Employees.EmployeeID = '{EmployeeID}'";
            SqlParameter[] sqlParameter = new SqlParameter[6];
            sqlParameter[0] = new SqlParameter("EmployeeID", EmployeeID);
            sqlParameter[1] = new SqlParameter("Firstname", Firstname);
            sqlParameter[2] = new SqlParameter("lastname", Lastname);
            sqlParameter[3] = new SqlParameter("Email", Email);
            sqlParameter[4] = new SqlParameter("Telephone", Telephone);
            sqlParameter[5] = new SqlParameter("Position", Position);
            ExecuteEditQuery(query, sqlParameter);
        }
        public void AddEmployee(string Firstname, string Lastname, string Email, string Position, string Password)
        {
            string query = $"insert into [Employees] (Firstname, Lastname, Email, Position, Password) VALUES ('{Firstname}','{Lastname}','{Email}','{Position}','{Password}')";
            SqlParameter[] sqlParameter = new SqlParameter[5];
            //sqlParameter[0] = new SqlParameter("EmployeeID", EmployeeID);
            sqlParameter[0] = new SqlParameter("Firstname", Firstname);
            sqlParameter[1] = new SqlParameter("lastname", Lastname);
            sqlParameter[2] = new SqlParameter("Email", Email);
            //sqlParameter[4] = new SqlParameter("Telephone", Telephone);
            sqlParameter[3] = new SqlParameter("Position", Position);
            sqlParameter[4] = new SqlParameter("Password", Password);
            ExecuteEditQuery(query, sqlParameter);
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employeeList = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee emplist = new Employee(
                Convert.ToInt32(dr["EmployeeID"]),
                dr["Firstname"].ToString(),
                dr["Lastname"].ToString(),
                dr["Email"].ToString(),
                (int)(123),
                dr["Position"].ToString()
                );
                employeeList.Add(emplist);
            }
            return employeeList;
        }
    }
}
