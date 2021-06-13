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
        private Order order;
        public OrderTableForm()
        {
            InitializeComponent();
            HideFormItemsForCreate();
        }

        private void InitForm()
        {
            if (tableService.CheckIfTableExistAndHasAnOrder(getCurrentTableId())){
                unHideFormItemsForCreate();
                this.order = tableService.getSingleOrder(getCurrentTableId());
                fillOrderGridWithItems();
            } else {
                HideFormItemsForCreate();
            }
            
            this.menuItems = tableService.getMenuCard();
            generateGridLayout(MenuItemsDataGridView, new string[] { "MenuItemID","MenuName","Price" });

            foreach (var item in this.menuItems)
            {
                FillDataInGridView(MenuItemsDataGridView, item.dataGrid(item));
            }
        }

        private void fillOrderGridWithItems()
        {
            ClearDataGridView(OrderItemsGridView);
            generateGridLayout(OrderItemsGridView, new string[] { "id", "Naam", "Price" });

            List<OrderItem> items = tableService.getMenuItemBelongingTowardsOrder(this.order.OrderID);
            foreach (var item in items)
            {
                FillDataInGridView(OrderItemsGridView, item.dataGrid(item));
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Want to delete the order?", "Delete Order?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (tableService.CheckIfTableExistAndHasAnOrder(getCurrentTableId())) {
                    tableService.deleteTableOrder(getCurrentTableId(), this.order.OrderID);
                }
                HideFormItemsForCreate();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (!tableService.CheckIfTableExistAndHasAnOrder(getCurrentTableId())) {
                tableService.createTableOrder(getCurrentTableId(), getCurrentUser().EmployeeID);
            }
            InitForm();
        }

        private void AddMenuItemToOrderButton_Click(object sender, EventArgs e)
        {
            int tableNumber;
            if (!Int32.TryParse(AddItemFromOrderTextBox.Text, out tableNumber))
            {
                MessageBox.Show("Insert a number");
                return;
            }

            if (!tableService.ItemExist(tableNumber)){
                MessageBox.Show("Item Doesnt Exist");
                return;
            }

            tableNumber = Int32.Parse(AddItemFromOrderTextBox.Text);
            tableService.AddMenuItemToOrder(tableNumber, this.order.OrderID);
            fillOrderGridWithItems();
        }

        private void RemoveMenuItemToOrderButton_Click(object sender, EventArgs e)
        {
            int orderItemID;
            if (!Int32.TryParse(RemoveItemFromOrderTextBox.Text, out orderItemID))
            {
                MessageBox.Show("Insert a number");
                return;
            }

            if (!tableService.OrderItemExist(orderItemID, this.order.OrderID))
            {
                MessageBox.Show("Order item is not in the current order");
                return;
            }

            orderItemID = Int32.Parse(RemoveItemFromOrderTextBox.Text);
            tableService.removeMenuItemToOrder(orderItemID);
            fillOrderGridWithItems();
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

        private void GoToTableDashboardButton_Click(object sender, EventArgs e)
        {
            showNewForm(new OrderForm(), this, getCurrentUser());
        }
    }
}
