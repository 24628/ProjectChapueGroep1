using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ChapooDatabaseModel
{
    public class Employee
    {
        public readonly int EmployeeID;
        public readonly string Firstname;
        public readonly string Lastname;
        public string Email;
        public float Telephone;
        public readonly string Position; 

        public Employee(int v1, string v2, string v3, string v4, float v6, string v7)
        {
            this.EmployeeID = v1;
            this.Firstname = v2;
            this.Lastname = v3;
            this.Email = v4;
            this.Telephone = v6;
            this.Position = v7;
        }
    }
}
