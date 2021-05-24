using System;
using System.Collections.Generic;
using System.Text;
using ChapooDatabaseDal;
using ChapooDatabaseModel;

namespace ChapooDatabaseLogic
{
    public class AuthenticationService
    {
        readonly ChapooDatabaseDal.AuthenticationDAO dao = new AuthenticationDAO();

        public bool CheckUserLogin(string email, string password)
        {
            if (dao.CheckUser(email, password) == 1)
                return true;
            else
                return false;
        }
        
        public Employee getSingleUser(string email)
        {
            return dao.getSingleUser(email);
        }
    }
}
