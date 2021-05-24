using ChapooDatabaseUI;
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
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginFormSubmitButton_Click(object sender, EventArgs e)
        {

            setUserWithEmail("BartSchutte@gmail.com");
            showNewForm(new DashboardForm(), this, getCurrentUser());
            /*
            ChapooDatabaseLogic.AuthenticationService AuthenticationService = new ChapooDatabaseLogic.AuthenticationService();
            string email = LoginFormEmailTextBox.Text;
            string password = LoginFormPasswordTextBox.Text;

            if(string.IsNullOrEmpty(email)){
                MessageBox.Show("Fill in the email field");
                return;
            }
            if (string.IsNullOrEmpty(password)){
                MessageBox.Show("Fill in the password field");
                return;
            }

            if (AuthenticationService.CheckUserLogin(email, password)){
                setUserWithEmail(email);
                showNewForm(new DashboardForm(), this, getCurrentUser());
            } else {
                MessageBox.Show("Wrong email or password!");
                return;
            }
            */
        }
    }
}
