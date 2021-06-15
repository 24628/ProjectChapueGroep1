using ChapooDatabaseLogic;
using ChapooDatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void fillOrderGridWithItems()
        {
            ClearDataGridView(OrderItemsGridView);
            generateGridLayout(OrderItemsGridView, new string[] { "id", "Naam", "Price", "amount" });

            List<OrderItem> items = tableService.getMenuItemBelongingTowardsOrder(this.order.OrderID);
            for (int i = 0; i < items.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < OrderItemsGridView.RowCount; j++)
                {

                    if (OrderItemsGridView.Rows[j].Cells[0].Value != null)
                        if (OrderItemsGridView.Rows[j].Cells[1].Value.ToString() == items[i].MenuName)
                            count++;
                }

                if(count == 0)
                    FillDataInGridView(OrderItemsGridView, dataGrid(items[i]));

                for (int j = 0; j < OrderItemsGridView.RowCount; j++)
                {
                    if (OrderItemsGridView.Rows[j].Cells[0].Value != null)
                    {
                        if (OrderItemsGridView.Rows[j].Cells[1].Value.ToString() == items[i].MenuName)
                        {
                            int amount = Int32.Parse(OrderItemsGridView.Rows[j].Cells[3].Value.ToString());
                            amount += 1;

                            string priceString = "€" + string.Format("{0:C2}", ((items[i].Price * amount)).ToString());
                            OrderItemsGridView.Rows[j].Cells[3].Value = (amount).ToString();
                            OrderItemsGridView.Rows[j].Cells[2].Value = string.Concat(priceString.Reverse().Skip(2).Reverse());
                        }
                    }
                }
            }
        }

        public string[] dataGrid(OrderItem m)
        {
            return new string[] {
                m.ID.ToString(),
                m.MenuName,
                string.Format("{0:C}", m.Price),
                "0"
            };
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
        private void BTTNFinishOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Want to finish the order?", "Finish Order?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                showNewForm(new OrderForm(), this, getCurrentUser());
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
            int MenuItemID;
            if (!Int32.TryParse(AddItemFromOrderTextBox.Text, out MenuItemID))
            {
                MessageBox.Show("Insert a number");
                return;
            }

            if (!tableService.ItemExist(MenuItemID)){
                MessageBox.Show("Item Doesnt Exist");
                return;
            }

            if (tableService.ThereIsStockOfTheItem(MenuItemID))
            {
                MessageBox.Show("There is no stock of this item!");
                return;
            }

            MenuItemID = Int32.Parse(AddItemFromOrderTextBox.Text);
            tableService.AddMenuItemToOrder(MenuItemID, this.order.OrderID);
            tableService.updateDecreaseStock(MenuItemID);
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
            BTTNFinishOrder.Hide();
            LunchButton.Hide();
            DinerButton.Hide();
            DrankAlcholButton.Hide();
            OrderItemsGridView.Hide();
            DrankButton.Hide();
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
            GoToTableDashboardButton.Show();
        }

        private void unHideFormItemsForCreate()
        {
            DeleteOrderButton.Show();
            BTTNFinishOrder.Show();
            OrderItemsGridView.Show();
            LunchButton.Show();
            DinerButton.Show();
            DrankAlcholButton.Show();
            OrderItemsGridView.Show();
            DrankButton.Show();
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
            GoToTableDashboardButton.Hide();
        }

        private void GoToTableDashboardButton_Click(object sender, EventArgs e)
        {
            showNewForm(new OrderForm(), this, getCurrentUser());
        }

        private void LunchButton_Click(object sender, EventArgs e)
        {
            ClearDataGridView(MenuItemsDataGridView);
            this.menuItems = tableService.getMenuCardLunch();
            generateGridLayout(MenuItemsDataGridView, new string[] { "MenuItemID", "MenuName", "Price" });

            foreach (var item in this.menuItems) {
                FillDataInGridView(MenuItemsDataGridView, item.dataGrid(item));
            }
        }

        private void DinerButton_Click(object sender, EventArgs e)
        {
            ClearDataGridView(MenuItemsDataGridView);
            this.menuItems = tableService.getMenuCardDiner();
            generateGridLayout(MenuItemsDataGridView, new string[] { "MenuItemID", "MenuName", "Price" });

            foreach (var item in this.menuItems)
            {
                FillDataInGridView(MenuItemsDataGridView, item.dataGrid(item));
            }
        }

        private void DrankAlcholButton_Click(object sender, EventArgs e)
        {
            ClearDataGridView(MenuItemsDataGridView);
            this.menuItems = tableService.getMenuCardDrankAlchol();
            generateGridLayout(MenuItemsDataGridView, new string[] { "MenuItemID", "MenuName", "Price" });

            foreach (var item in this.menuItems)
            {
                FillDataInGridView(MenuItemsDataGridView, item.dataGrid(item));
            }
        }

        private void DrankButton_Click(object sender, EventArgs e)
        {
            ClearDataGridView(MenuItemsDataGridView);
            this.menuItems = tableService.getMenuCardDrank();
            generateGridLayout(MenuItemsDataGridView, new string[] { "MenuItemID", "MenuName", "Price" });

            foreach (var item in this.menuItems)
            {
                FillDataInGridView(MenuItemsDataGridView, item.dataGrid(item));
            }
        }


    }
}
