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
        TableService tableService;
        MenuItem selectedMenuItem;
        Menu selectedMenu;

        public AdminMenu()
        {
            menuItemService = new MenuItemService();
            tableService = new TableService();
            InitializeComponent();
            displayGrid();
            showMenuTypeGrid();
        }

        private void showMenuTypeGrid()
        {
            ClearDataGridView(MenuTypesGrid);
            generateGridLayout(MenuTypesGrid, new string[] {"type"});

            List<Menu> menuTypes = menuItemService.getMenuTypes();
            foreach (var e in menuTypes)
            {
                FillDataInGridView(MenuTypesGrid, dataGridMenuTypes(e));
            }
            
        }

        public string[] dataGridMenuTypes(Menu m)
        {
            return new string[] {
                m.Type,
            };
        }
        private void displayGrid()
        {

            ClearDataGridView(AdminMenuGrid);
            generateGridLayout(AdminMenuGrid, new string[] {"Name", "Price" });

            List<AdminMenuItem> menu = menuItemService.GetAllItems();
            foreach (var e in menu)
            {
                FillDataInGridView(AdminMenuGrid, dataGrid(e));
            }
        }

        public string[] dataGrid(AdminMenuItem m)
        {
            return new string[] {
                m.Name,
                string.Format("{0:C}", m.Price)
            };
        }

        private void BTN_MIMenuUpdate_Click(object sender, EventArgs e)
        {
            decimal price;
            if (TXTB_MIMenuName.Text == string.Empty) {
                MessageBox.Show("Fill in a menu name");
                return;
            }

            if(!decimal.TryParse(TXTB_MIPrice.Text, out price))  {
                MessageBox.Show("Fill in correct price");
                return;
            }
            int MenuItemID = this.selectedMenuItem.Id;
            string MenuName = TXTB_MIMenuName.Text;
            price = decimal.Parse(TXTB_MIPrice.Text)/100;

            menuItemService.UpdateMenuItem(MenuItemID, MenuName, price);

            if (TXTB_Menutype.Text != string.Empty)
            {
                bool found = false;
                foreach (var x in menuItemService.getMenuTypes())
                {
                    if (x.Type == TXTB_Menutype.Text) found = true;        
                }
                if (found == true) {
                    MessageBox.Show("Changed this menu item " + selectedMenuItem.Name + " to this menu" + selectedMenu.Type);
                    menuItemService.UpdateMenuItemType(MenuItemID, this.selectedMenu.Id);
                } else MessageBox.Show("Menu type not found!");
            }
            MessageBox.Show("De Item wijzigingen zijn doorgevoerd", "Item Wijzigingen!", MessageBoxButtons.OK);
            displayGrid();
        }

        private void BTN_MIMenuAdd_Click(object sender, EventArgs e)
        {
            bool found = false;
            
            foreach (var x in menuItemService.getMenuTypes()) {
                if (TXTB_Menutype.Text != string.Empty)
                    if (x.Type == TXTB_Menutype.Text) found = true;
            }
            if (!found) {
                MessageBox.Show("Menu type not found!");
                return;
            }

            decimal price;
            if (TXTB_MIMenuName.Text == string.Empty)
            {
                MessageBox.Show("Fill in a menu name");
                return;
            }

            if (!decimal.TryParse(TXTB_MIPrice.Text, out price))
            {
                MessageBox.Show("Fill in correct price");
                return;
            }
            string MenuName = TXTB_MIMenuName.Text;
            price = decimal.Parse(TXTB_MIPrice.Text) / 100;

            menuItemService.AddMenuItem(this.selectedMenu.Id, MenuName, price);
            MessageBox.Show("Menu Item toegevoegd", "Menu Item!", MessageBoxButtons.OK);

            displayGrid();
        }
        private void BTN_MIDelete_Click(object sender, EventArgs e)
        {
            if(this.selectedMenuItem == null)
            {
                MessageBox.Show("Select an item!");
                return;
            }
            menuItemService.DeleteMenuItem(this.selectedMenuItem.Id);
            MessageBox.Show("MenuItem Gedelete", "MenuItem!", MessageBoxButtons.OK);
            displayGrid();
        }

        private void BTN_MITerug_Click(object sender, EventArgs e)
        {
            showNewForm(new AdministratorForm(), this, getCurrentUser());
        }

        private void AdminMenuGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int row = 0; row < AdminMenuGrid.RowCount; row++)
            {
                if (AdminMenuGrid.SelectedRows.Count == 1)
                {
                    if (AdminMenuGrid.Rows[row].Cells[0] == AdminMenuGrid.SelectedRows[0].Cells[0])
                    {
                        string selectedItemName = (string)AdminMenuGrid.SelectedRows[0].Cells[0].Value;
                        this.selectedMenuItem = tableService.findMenuItem(selectedItemName);
                        TXTB_MIMenuName.Text = selectedMenuItem.Name;
                        TXTB_MIPrice.Text = string.Format("{0:C}", selectedMenuItem.Price).Remove(0, 1);
                    }
                }
            }
        }

        private void MenuTypesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int row = 0; row < MenuTypesGrid.RowCount; row++)
            {
                if (MenuTypesGrid.SelectedRows.Count == 1)
                {
                    if (MenuTypesGrid.Rows[row].Cells[0] == MenuTypesGrid.SelectedRows[0].Cells[0])
                    {
                        string selectedMenuType = (string)MenuTypesGrid.SelectedRows[0].Cells[0].Value;
                        this.selectedMenu = tableService.findMenuType(selectedMenuType);
                        TXTB_Menutype.Text = selectedMenu.Type;
                    }
                }
            }
        }
    }
}
