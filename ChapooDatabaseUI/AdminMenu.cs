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
    public partial class AdminMenu : BaseForm
    {
        MenuItemService menuItemService;
        public AdminMenu()
        {
            menuItemService = new MenuItemService();
            InitializeComponent();
        }
        private void AdminMenuGrid_CellContentClick(object sender, EventArgs e)
        {
            //AdminMenuGrid.Columns.Add("MenuItemID", "MenuItemID");
            AdminMenuGrid.Columns.Add("MenuID", "MenuID");
            AdminMenuGrid.Columns.Add("MenuName", "MenuName");
            AdminMenuGrid.Columns.Add("Price", "Price");
            foreach (MenuItem menuitem in menuItemService.GetAllItems())
            {
                string[] row = { menuitem.Id.ToString(), menuitem.Id.ToString(), menuitem.Name, menuitem.Price.ToString() };
                AdminMenuGrid.Rows.Add(row);
            }
        }
        private void BTN_MIMenuUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AdminMenuGrid.Rows.Count - 1; i++)
            {
              //int MenuItemID = int.Parse(AdminMenuGrid.Rows[i].Cells[0].Value.ToString());
                int MenuID = int.Parse(AdminMenuGrid.Rows[i].Cells[1].Value.ToString());
                string MenuName = (AdminMenuGrid.Rows[i].Cells[2].Value.ToString());
                int Price = int.Parse(AdminMenuGrid.Rows[i].Cells[3].Value.ToString());
                menuItemService.UpdateMenuItem(MenuID, MenuName, Price);
            }
            MessageBox.Show("De Item wijzigingen zijn doorgevoerd", "Item Wijzigingen!", MessageBoxButtons.OK);
        }
        public bool MenuItemCheck(String MenuName) // check of de MenuItem al bestaat
        {
            foreach (MenuItem menuItem in menuItemService.GetAllItems())
            {
                if (MenuName == menuItem.Name) { return true; }
            }
            return false;
        }
        private void EmtyTextboxMenuItem() // maak de textbox leeg naar gebruik
        {
            TXTB_MIMenuItemID.Text = string.Empty;
            TXTB_MIMenuID.Text = string.Empty;
            TXTB_MIMenuName.Text = string.Empty;
            TXTB_MIPrice.Text = string.Empty;
        }
        private void BTN_MIMenuAdd_Click(object sender, EventArgs e)
        {

            //int MenuItemID = int.Parse(TXTB_MIMenuItemID.Text.ToString());
            int MenuID = int.Parse(TXTB_MIMenuID.Text.ToString());
            string MenuName = TXTB_MIMenuName.Text;
            decimal Price = Convert.ToDecimal(TXTB_MIPrice.Text.ToString());
            if (!MenuItemCheck(MenuName))
            {
                menuItemService.AddMenuItem( MenuID, MenuName, Price);
                MessageBox.Show("Menu Item toegevoegd", "Menu Item!", MessageBoxButtons.OK);
                EmtyTextboxMenuItem();
                return;
            }
            MessageBox.Show("Menu Item bestaat al", "Menu Item!", MessageBoxButtons.OK);
            EmtyTextboxMenuItem();
        }
        private void BTN_MIDelete_Click(object sender, EventArgs e)
        {
            int Index = AdminMenuGrid.CurrentCell.RowIndex;
            AdminMenuGrid.Rows.RemoveAt(Index);
            List<MenuItem> menu = menuItemService.GetAllItems();
            MenuItem DeleteItem = menu[Index];
        }
    }
}
