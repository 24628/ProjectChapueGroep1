using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using ChapooDatabaseDal;
using ChapooDatabaseLogic;
using ChapooDatabaseModel;
using ChapooDatabaseUI.Enums;

namespace ChapooDatabaseUI
{
    public partial class AdminEmployee : BaseForm
    {
        EmployeeService employeeService;
        Employee selectedEmployee;
        public AdminEmployee()
        {
            employeeService = new EmployeeService();
            InitializeComponent();
            displayGrid();
        }

        private void displayGrid()
        {

            ClearDataGridView(AdminEmployGrid);
            generateGridLayout(AdminEmployGrid, new string[] {"Firstname", "Lastname" , "Email", "Telephone" , "Position" });

            List<Employee> emp = employeeService.GetAllEmployees();
            foreach (var e in emp)
            { 
                FillDataInGridView(AdminEmployGrid, dataGrid(e));
            }
        }

        public string[] dataGrid(Employee m)
        {
            return new string[] {
                m.Firstname,
                m.Lastname,
                m.Email,
                m.Telephone.ToString("F1", new CultureInfo("en-US").NumberFormat),
                m.Position
            };
        }
        private void BTN_ADUpdate_Click(object sender, EventArgs e)
        {

            float Telephone;
            if (!float.TryParse(TXTB_ADTelephone.Text, out Telephone))
            {
                MessageBox.Show("Incorrect phone number");
                return;
            }

            IDictionary<System.Windows.Forms.TextBox, string> textFields = new Dictionary<System.Windows.Forms.TextBox, string>();
            textFields.Add(TXTB_ADFirstname, "Firstname");
            textFields.Add(TXTB_ADLastname, "Lastname");
            textFields.Add(TXTB_ADGebruikersnaam, "Email");
            textFields.Add(TXTB_ADPosition, "Position");

            foreach (var fields in textFields)
            {
                if (fields.Key.Text == string.Empty)
                {
                    MessageBox.Show("fill in " + fields.Value);
                    return;
                }
            }

            bool foundPos = false;
            foreach (RoleEnums pos in Enum.GetValues(typeof(RoleEnums)))
                if (pos.ToString() == TXTB_ADPosition.Text) foundPos = true;

            if (!foundPos) {
                MessageBox.Show("Wrong position");
                return;
            }

            int EmployeeID = this.selectedEmployee.EmployeeID;
            string Firstname = TXTB_ADFirstname.Text;
            string Lastname = TXTB_ADLastname.Text;
            string Email = TXTB_ADGebruikersnaam.Text;
            string password = TXTB_ADPassword.Text;
            string Position = TXTB_ADPosition.Text;
            Telephone = float.Parse(TXTB_ADTelephone.Text);

            if (this.selectedEmployee.Email != Email) { // Eerste checken we of deze curren email text field gelijk staat aan de employee die we updaten
                if (EmployeeCheck(Email)) { //kijken of de email uniek is!
                    MessageBox.Show("Deze email bestaat al! kies een anderen");
                    return;
                }
            }

            employeeService.UpdateEmployee(EmployeeID, Firstname, Lastname, Email, Telephone, Position);

            if(TXTB_ADPassword.Text != string.Empty) 
                employeeService.UpdateEmployeePassword(EmployeeID, password);
            
            MessageBox.Show("De Employee wijzigingen zijn doorgevoerd", "Employee Wijzigingen!", MessageBoxButtons.OK);

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

        private void BTN_ADToevoegen_Click(object sender, EventArgs e) 
        {
            float Telephone;
            if (!float.TryParse(TXTB_ADTelephone.Text, out Telephone))
            {
                MessageBox.Show("Incorrect phone number");
                return;
            }

            IDictionary<System.Windows.Forms.TextBox, string> textFields = new Dictionary<System.Windows.Forms.TextBox, string>();
            textFields.Add(TXTB_ADFirstname, "Firstname");
            textFields.Add(TXTB_ADLastname, "Lastname");
            textFields.Add(TXTB_ADGebruikersnaam, "Email");
            textFields.Add(TXTB_ADPosition, "Position");
            textFields.Add(TXTB_ADPassword, "Password");

            foreach (var fields in textFields)
            {
                if (fields.Key.Text == string.Empty)
                {
                    MessageBox.Show("fill in " + fields.Value);
                    return;
                }
            }

            bool foundPos = false;
            foreach (RoleEnums pos in Enum.GetValues(typeof(RoleEnums))) 
                if (pos.ToString() == TXTB_ADPosition.Text) foundPos = true;

            if (!foundPos) {
                MessageBox.Show("Wrong position");
                return;
            }

            string Firstname = TXTB_ADFirstname.Text;
            string Lastname = TXTB_ADLastname.Text;
            string Email = TXTB_ADGebruikersnaam.Text;
            string password = TXTB_ADPassword.Text;
            string Position = TXTB_ADPosition.Text;
            Telephone = float.Parse(TXTB_ADTelephone.Text);

            if (EmployeeCheck(Email)) { //kijken of de email uniek is!
                MessageBox.Show("Deze email bestaat al! kies een anderen");
                return;
            }

            employeeService.AddEmployee(Firstname, Lastname, Email, Position, password, Telephone);

            displayGrid();
        }

        private void BTN_ADDelete_Click(object sender, EventArgs e)
        {
            if(this.selectedEmployee.EmployeeID == getCurrentUser().EmployeeID) {
                MessageBox.Show("Cant delete ur self!");
                return;
            }

            if(this.selectedEmployee.Position == RoleEnums.Eigenaar.ToString()) {
                MessageBox.Show("Cant delete some1 with Eigenaar role!");
                return;
            }

            employeeService.DeleteEmployee(this.selectedEmployee.EmployeeID);
            this.selectedEmployee = null;

            IDictionary<System.Windows.Forms.TextBox, string> textFields = new Dictionary<System.Windows.Forms.TextBox, string>();
            textFields.Add(TXTB_ADFirstname, "Firstname");
            textFields.Add(TXTB_ADLastname, "Lastname");
            textFields.Add(TXTB_ADGebruikersnaam, "Email");
            textFields.Add(TXTB_ADPosition, "Position");
            textFields.Add(TXTB_ADPassword, "Password");

            foreach (var fields in textFields)
                fields.Key.Text = string.Empty;
            

            MessageBox.Show("Employee Gedelete", "Employee!", MessageBoxButtons.OK);
            displayGrid();
        }

        private void BTN_ADTerug_Click(object sender, EventArgs e)
        {
            showNewForm(new AdministratorForm(), this, getCurrentUser());
        }

        private void AdminEmployGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Voor elke row in de grid loopen wij er door heen
            for (int row = 0; row < AdminEmployGrid.RowCount; row++)
            {
                //Kijken we er of een geselcteerde grid is
                if (AdminEmployGrid.SelectedRows.Count == 1)
                {
                    //Kijken grid row data cell value 1 gelijk staat aan de geselecteerde grid!
                    if (AdminEmployGrid.Rows[row].Cells[0] == AdminEmployGrid.SelectedRows[0].Cells[0])
                    {
                        string selectedEmploye = (string)AdminEmployGrid.SelectedRows[0].Cells[2].Value;
                        this.selectedEmployee = employeeService.findEmployeeByStringEmail(selectedEmploye);

                        //fill fields
                        TXTB_ADFirstname.Text = this.selectedEmployee.Firstname;
                        TXTB_ADLastname.Text = this.selectedEmployee.Lastname;
                        TXTB_ADGebruikersnaam.Text = this.selectedEmployee.Email;
                        TXTB_ADPosition.Text = this.selectedEmployee.Position;
                        TXTB_ADTelephone.Text = this.selectedEmployee.Telephone.ToString("F1", new CultureInfo("en-US").NumberFormat);
                    }
                }
            }
        }
    }
}
