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
            FormToShow.WindowState = FormWindowState.Maximized;
            FormToShow.UpdateUser(emp);
            FormToHide.Hide();
        }

        public void OrderButton(BaseForm form) {
            showNewForm(new OrderForm(), form, getCurrentUser());
        }

        public void PaymentButton(BaseForm form) {
            showNewForm(new PaymentForm(), form, getCurrentUser());
        }

        public void KitchenButton(BaseForm form) {
            showNewForm(new KitchenForm(), form, getCurrentUser());
        }

        public void AdministratorButton(BaseForm form) {
            showNewForm(new AdministratorForm(), form, getCurrentUser());
        }

        public void KassaButton(BaseForm form) {
            showNewForm(new KassaForm(), form, getCurrentUser());
        }
    }
}
