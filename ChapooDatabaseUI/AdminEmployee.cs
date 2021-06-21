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
            displayGrid();
        }

        private void displayGrid()
        {

            ClearDataGridView(AdminEmployGrid);
            generateGridLayout(AdminEmployGrid, new string[] { "EmployeeID", "Firstname", "Lastname" , "Email", "Telephone" , "Position" });

            List<Employee> emp = employeeService.GetAllEmployees();
            foreach (var e in emp)
            { 
                FillDataInGridView(AdminEmployGrid, e.dataGrid(e));
            }
        }
        private void BTN_ADUpdate_Click(object sender, EventArgs e)
        {

            int EmployeeID;
            float Telephone;
            if (!float.TryParse(TXTB_ADTelephone.Text, out Telephone))
            {
                MessageBox.Show("Incorrect phone number");
                return;
            }

            if (!Int32.TryParse(TXTB_ADEmployeeID.Text, out EmployeeID))
            {
                MessageBox.Show("Insert an id at Employee id");
                return;
            }

            IDictionary<System.Windows.Forms.TextBox, string> textFields = new Dictionary<System.Windows.Forms.TextBox, string>();
            textFields.Add(TXTB_ADFirstname, "Firstname");
            textFields.Add(TXTB_ADLastname, "Lastname");
            textFields.Add(TXTB_ADGebruikersnaam, "Email");
            textFields.Add(TXTB_ADPassword, "password");
            textFields.Add(TXTB_ADPosition, "Position");

            foreach (var fields in textFields)
            {
                if (fields.Key.Text == string.Empty)
                {
                    MessageBox.Show("fill in " + fields.Value);
                    return;
                }
            }

            string Firstname = TXTB_ADFirstname.Text;
            string Lastname = TXTB_ADLastname.Text;
            string Email = TXTB_ADGebruikersnaam.Text;
            string password = TXTB_ADPassword.Text;
            string Position = TXTB_ADPosition.Text;

            Telephone = float.Parse(TXTB_ADTelephone.Text);
            EmployeeID = Int32.Parse(TXTB_ADEmployeeID.Text);

            if (!employeeService.EmployeeExist(EmployeeID))
            {
                MessageBox.Show("Employee doesnt exist check the id again!");
                return;
            }

            employeeService.UpdateEmployee(EmployeeID, Firstname, Lastname, Email, password, Telephone, Position);
            
            MessageBox.Show("De Employee wijzigingen zijn doorgevoerd", "Employee Wijzigingen!", MessageBoxButtons.OK);

            EmtyTextbox();
            displayGrid();
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

        private void BTN_ADToevoegen_Click(object sender, EventArgs e) 
        {
            string Firstname = TXTB_ADFirstname.Text;
            string Lastname = TXTB_ADLastname.Text;
            string Email = TXTB_ADGebruikersnaam.Text;
            float Telephone = float.Parse(TXTB_ADTelephone.Text);
            string Position = TXTB_ADPosition.Text;
            string Password = TXTB_ADPassword.Text;
            if (!EmployeeCheck(Email)) {
                employeeService.AddEmployee(Firstname, Lastname, Email, Position, Password, Telephone);
                MessageBox.Show("Employee toegevoegd", "Employee!", MessageBoxButtons.OK);
            } else MessageBox.Show("employee bestaat al", "Employee!", MessageBoxButtons.OK);
            EmtyTextbox();
            displayGrid();
        }

        private void BTN_ADDelete_Click(object sender, EventArgs e)
        {
            int EmployeeID;
            if (!Int32.TryParse(TXTB_ADEmployeeID.Text, out EmployeeID))
            {
                MessageBox.Show("Insert an id at Employee id");
                return;
            }

            if (!employeeService.EmployeeExist(EmployeeID))
            {
                MessageBox.Show("Employee doesnt exist check the id again!");
                return;
            }

            EmployeeID = Int32.Parse(TXTB_ADEmployeeID.Text);
            employeeService.DeleteEmployee(EmployeeID);
            MessageBox.Show("Employee Gedelete", "Employee!", MessageBoxButtons.OK);
            displayGrid();
        }

        private void BTN_ADTerug_Click(object sender, EventArgs e)
        {
            showNewForm(new AdministratorForm(), this, getCurrentUser());
        }
    }
}
