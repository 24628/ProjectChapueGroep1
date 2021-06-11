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
    public partial class AdminEmployee : BaseForm
    {
        EmployeeService employeeService;
        public AdminEmployee()
        {
            employeeService = new EmployeeService();
            InitializeComponent();
        }

        private void AdminEmployGrid_CellContentClick(object sender, EventArgs e)
        {
            AdminEmployGrid.Columns.Add("EmployeeID", "EmployeeID");
            AdminEmployGrid.Columns.Add("Firstname", "Firstname");
            AdminEmployGrid.Columns.Add("Lastname", "Lastname");
            AdminEmployGrid.Columns.Add("Email", "Email");
            AdminEmployGrid.Columns.Add("Telephone", "Telephone");
            AdminEmployGrid.Columns.Add("Position", "Position");
            foreach (Employee employee in employeeService.GetAllEmployees())
            {
                //if (employee.Telephone >= 9) { employee.Telephone = 0; }
                string[] row = { employee.EmployeeID.ToString(), employee.Firstname, employee.Lastname, employee.Email, employee.Telephone.ToString(), employee.Position };

                AdminEmployGrid.Rows.Add(row);
            }
        }
        private void BTN_ADUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AdminEmployGrid.Rows.Count - 1; i++)
            {
                int EmployeeID = int.Parse(AdminEmployGrid.Rows[i].Cells[0].Value.ToString());
                string Firstname = AdminEmployGrid.Rows[i].Cells[1].Value.ToString();
                string Lastname = (AdminEmployGrid.Rows[i].Cells[2].Value.ToString());
                string Email = (AdminEmployGrid.Rows[i].Cells[3].Value.ToString());
                int Telephone = int.Parse(AdminEmployGrid.Rows[i].Cells[4].Value.ToString());
                string Position = (AdminEmployGrid.Rows[i].Cells[5].Value.ToString());
                employeeService.UpdateEmployee(EmployeeID, Firstname, Lastname, Email, Telephone, Position);
            }
            MessageBox.Show("De Employee wijzigingen zijn doorgevoerd", "Employee Wijzigingen!", MessageBoxButtons.OK);
        }
        public bool EmployeeCheck(String Email) // check of de Employee al bestaat
        {
            foreach (Employee employee in employeeService.GetAllEmployees())
            {
                if (Email == employee.Email)
                {
                    return true;
                }
            }
            return false;
        }
        public void EmtyTextbox() // maak de textbox leeg naar gebruik
        {
            TXTB_ADEmployeeID.Text = string.Empty;
            TXTB_ADFirstname.Text = string.Empty;
            TXTB_ADLastname.Text = string.Empty;
            TXTB_ADGebruikersnaam.Text = string.Empty;
            TXTB_ADPassword.Text = string.Empty;
            TXTB_ADPosition.Text = string.Empty;
            TXTB_ADTelephone.Text = string.Empty;
        }

        private void BTN_ADToevoegen_Click(object sender, EventArgs e) // Voeg iemand toe haha
        {
            //int EmployeeID = int.Parse(TXTB_ADEmployeeID.Text.ToString());
            string Firstname = TXTB_ADFirstname.Text;
            string Lastname = TXTB_ADLastname.Text;
            string Email = TXTB_ADGebruikersnaam.Text;
            //float Telephone = float.Parse(TXTB_ADTelephone.Text.ToString());
            string Position = TXTB_ADPosition.Text;
            string Password = TXTB_ADPassword.Text;
            if (!EmployeeCheck(Email))
            {
                employeeService.AddEmployee(Firstname, Lastname, Email, Position, Password);
                MessageBox.Show("Employee toegevoegd", "Employee!", MessageBoxButtons.OK);
                EmtyTextbox();
                return; //
            }
            MessageBox.Show("employee bestaat al", "Employee!", MessageBoxButtons.OK);
            EmtyTextbox();
        }

        private void BTN_ADDelete_Click(object sender, EventArgs e)
        {
            int Index = AdminEmployGrid.CurrentCell.RowIndex;
            AdminEmployGrid.Rows.RemoveAt(Index);
            List<Employee> employees = employeeService.GetAllEmployees();
            Employee DeleteUser = employees[Index];
        }
    }
}
