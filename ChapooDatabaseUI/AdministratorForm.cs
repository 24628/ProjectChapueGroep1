using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChapooDatabaseDal;
using ChapooDatabaseLogic;
using ChapooDatabaseModel;

namespace ChapooDatabaseUI
{
    public partial class AdministratorForm : BaseForm
    {
        EmployeeService employeeService;
        MenuItemService menuItemService;
        public AdministratorForm()
        {
            employeeService = new EmployeeService();
            menuItemService = new MenuItemService();
            InitializeComponent();
        }
        private void BTN_Werknemers_Click(object sender, EventArgs e)
        {
            AdminEmployee adminEmployee = new AdminEmployee();
            adminEmployee.ShowDialog();
        }
        private void BTN_MenuItem_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.ShowDialog();
        }
        private void BTN_Voorraad_Click(object sender, EventArgs e)
        {
            AdminVoorraad adminVoorraad = new AdminVoorraad();
            adminVoorraad.ShowDialog();
        }
    }
}
