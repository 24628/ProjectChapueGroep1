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
            return dao.GetAllEmployee();
        }
    }
}
