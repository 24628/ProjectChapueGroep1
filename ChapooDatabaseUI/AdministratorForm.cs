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
        public AdministratorForm()
        {
            InitializeComponent();
        }
        private void BTN_Werknemers_Click(object sender, EventArgs e)
        {
            showNewForm(new AdminEmployee(), this, getCurrentUser());
        }
        private void BTN_MenuItem_Click(object sender, EventArgs e)
        {
            showNewForm(new AdminMenu(), this, getCurrentUser());
        }
        private void BTN_Voorraad_Click(object sender, EventArgs e)
        {
            showNewForm(new AdminVoorraad(), this, getCurrentUser());
        }
    }
}
