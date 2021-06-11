using System;
using System.Collections.Generic;
using System.Text;
using ChapooDatabaseDal;
using ChapooDatabaseModel;

namespace ChapooDatabaseLogic
{
    public class EmployeeService
    {
        readonly ChapooDatabaseDal.EmployeeDAO dao = new EmployeeDAO();
        
        public List<Employee> GetAllEmployees()
        {
            try
            {
                return dao.GetAllEmployee();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            
        }
        public void UpdateEmployee(int EmployeeID, string Firstname, string lastname, string Email, int Telephone, string Position)
        {
            try
            {
                dao.UpdateEmploy(EmployeeID, Firstname, lastname, Email, Telephone, Position);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void AddEmployee(string Firstname, string Lastname, string Email, string Position, string Password)
        {
            try
            {
                dao.AddEmployee(Firstname, Lastname,  Email, Position, Password);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
