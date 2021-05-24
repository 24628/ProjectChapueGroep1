using ChapooDatabaseModel;
using ChapooUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapooDatabaseUI
{
    public partial class BaseForm : Form
    {
        private Employee employee;
        public Form loginForm;

        public void setUserWithEmail(string email)
        {
            ChapooDatabaseLogic.AuthenticationService AuthenticationService = new ChapooDatabaseLogic.AuthenticationService();
            this.employee = AuthenticationService.getSingleUser(email);
        }

        public Employee getCurrentUser()
        {
            return this.employee;
        }

        public void UpdateUser(Employee e)
        {
            this.employee = e;
        }
        public void showNewForm(BaseForm FormToShow, BaseForm FormToHide, Employee emp)
        {
            FormToShow.Show();
            FormToShow.UpdateUser(emp);
            FormToHide.Hide();
        }
    }
}
