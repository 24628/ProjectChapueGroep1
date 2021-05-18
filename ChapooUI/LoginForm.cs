using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChapooUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginFormSubmitButton_Click(object sender, EventArgs e)
        {
            ChapooDatabaseLogic.AuthenticationService AuthenticationService = new ChapooDatabaseLogic.AuthenticationService();

            // get the email and password from textboxes
            string email = LoginFormEmailTextBox.Text;
            string password = LoginFormPasswordTextBox.Text;

            // if validuser then show application and hide login and register and password forgotten
            if (AuthenticationService.CheckUserLogin(email, password))
            {
                MessageBox.Show("Login succesful!");
                return;
            }
            else
            {
                MessageBox.Show("Wrong email or password!"); // show messagebox with message, application keeps running
                return;
            }
        }
    }
}
