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
            displayGrid();
            showMenuTypeGrid();
        }

        private void showMenuTypeGrid()
        {
            ClearDataGridView(MenuTypesGrid);
            generateGridLayout(MenuTypesGrid, new string[] { "Menu Id", "type",});

            List<Menu> menuTypes = menuItemService.getMenuTypes();
            foreach (var e in menuTypes)
            {
                FillDataInGridView(MenuTypesGrid, e.dataGrid(e));
            }
            
        }
        private void displayGrid()
        {

            ClearDataGridView(AdminMenuGrid);
            generateGridLayout(AdminMenuGrid, new string[] {"Menu Id", "item Id", "Name", "Price" });

            List<AdminMenuItem> menu = menuItemService.GetAllItems();
            foreach (var e in menu)
            {
                FillDataInGridView(AdminMenuGrid, e.dataGrid(e));
            }
        }
        private void BTN_MIMenuUpdate_Click(object sender, EventArgs e)
        {
            int MenuItemID = Int32.Parse(TXTB_MIMenuItemID.Text);
            string MenuName = TXTB_MIMenuName.Text;
            decimal Price = decimal.Parse(TXTB_MIPrice.Text);
            menuItemService.UpdateMenuItem(MenuItemID, MenuName, Price);
            MessageBox.Show("De Item wijzigingen zijn doorgevoerd", "Item Wijzigingen!", MessageBoxButtons.OK);
            displayGrid();
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

            int MenuID = int.Parse(TXTB_MIMenuID.Text);
            string MenuName = TXTB_MIMenuName.Text;
            decimal Price = Convert.ToDecimal(TXTB_MIPrice.Text);
            menuItemService.AddMenuItem( MenuID, MenuName, Price);
            MessageBox.Show("Menu Item toegevoegd", "Menu Item!", MessageBoxButtons.OK);
            EmtyTextboxMenuItem();
            displayGrid();
        }
        private void BTN_MIDelete_Click(object sender, EventArgs e)
        {
            menuItemService.DeleteMenuItem(int.Parse(TXTB_MIMenuItemID.Text));
            displayGrid();
        }
    }
}
