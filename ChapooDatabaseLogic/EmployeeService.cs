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
        public void UpdateEmployee(int EmployeeID, string Firstname, string lastname, string Email, string password, float Telephone, string Position)
        {
            try
            {
                dao.UpdateEmploy(EmployeeID, Firstname, lastname, Email, password, Telephone, Position);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void AddEmployee(string Firstname, string Lastname, string Email, string Position, string Password, float tn)
        {
            try
            {
                dao.AddEmployee(Firstname, Lastname,  Email, Position, Password, tn);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteEmployee(int id)
        {
            dao.DeleteEmployee(id);
        }
    }
}
