using ChapooDatabaseLogic;
using ChapooDatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapooDatabaseUI
{
    public partial class OrderTableForm : BaseForm
    {
        private TableService tableService = new TableService();
        private List<MenuItem> menuItems;
        public OrderTableForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            HideFormItemsForCreate();
            this.menuItems = tableService.getMenuCard();
            generateGridLayout(MenuItemsDataGridView, new string[] { "MenuItemID","MenuName","Price" });

            foreach (var item in this.menuItems)
            {
                FillDataInGridView(MenuItemsDataGridView, item.dataGrid(item));
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            HideFormItemsForCreate();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            unHideFormItemsForCreate();
        }

        private void AddMenuItemToOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveMenuItemToOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void HideFormItemsForCreate()
        {
            DeleteOrderButton.Hide();
            OrderItemsGridView.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            MenuItemsDataGridView.Hide();
            AddItemFromOrderTextBox.Hide();
            RemoveItemFromOrderTextBox.Hide();
            RemoveMenuItemToOrderButton.Hide();
            AddMenuItemToOrderButton.Hide();

            CreateOrderButton.Show();
        }

        private void unHideFormItemsForCreate()
        {
            DeleteOrderButton.Show();
            OrderItemsGridView.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            MenuItemsDataGridView.Show();
            AddItemFromOrderTextBox.Show();
            RemoveItemFromOrderTextBox.Show();
            RemoveMenuItemToOrderButton.Show();
            AddMenuItemToOrderButton.Show();

            CreateOrderButton.Hide();
        }
    }
}
