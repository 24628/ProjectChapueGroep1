using ChapooDatabaseLogic;
using ChapooDatabaseModel;
using ChapooDatabaseUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapooDatabaseUI
{
    public partial class PaymentForm : BaseForm
    {
        private const int size = 120;
        private const int padding = 18;
        private string pricePlaceHolder = "Total Price: ";

        private TableService tableService = new TableService();
        private List<Table> TableList;
        private List<OrderItem> orderList;
        private decimal totalPrice;
        private decimal totalPriceBtwAdd;
        private Table table = null;
        public decimal Btw;
        private string Status = string.Empty;
        private bool booleanTableIsClicked = false;

        public PaymentForm()
        {
            InitializeComponent();
            dispayTables();
        }

        private void setTableList()
        {
            this.TableList = tableService.GetAllTables();
        }

        private void dispayTables()
        {
            TableHolderFlowLayout.Controls.Clear();
            setTableList();

            foreach (Table table in this.TableList)
            {
                CustomButton button = new CustomButton
                {
                    Size = new Size(size, size),
                    Margin = new Padding(padding, padding, padding, padding),
                    Text = $"Table {table.TableId}",
                    Tag = table
                };

                button.Text += getTableStatus(table);

                // Display table colour based on status
                button.BackColor = table.setTableColor(table.Status);

                if (table.Status != "Free")
                    button.Click += new EventHandler(Table_Click);

                TableHolderFlowLayout.Controls.Add(button);
            }
        }

        private string getTableStatus(Table table)
        {
            return table.Status;
        }

        private void Table_Click(object sender, EventArgs e)
        {
            this.booleanTableIsClicked = true;
            Button button = (Button)sender;
            table = (Table)button.Tag;

            this.orderList = tableService.getReceerdOrderForTableById(table.TableId);

            ClearDataGridView(dataGridView1);
            generateGridLayout(dataGridView1, new string[] { "id", "Naam", "Price" });

            totalPrice = 0;
            foreach (var item in orderList)
            {
                FillDataInGridView(dataGridView1, dataGrid(item));
                totalPrice += item.Price;
            }

            (string FinalTotaal, string TotaalBTW) = calcPrice();
        }

        public string[] dataGrid(OrderItem m)
        {
            return new string[] {
                m.ID.ToString(),
                m.MenuName,
                string.Format("{0:C}", m.Price),
                m.date
            };
        }

        private (string totaalPrice, string totaalBtw) calcPrice()
        {
            decimal tip = 0.00m;
            decimal TotaalBTW = 0;
            decimal totaalprijsWithoutBTW = 0;
            decimal FinalTotaal = 0;
            if (TXT_Tip.Text != string.Empty)
                tip = Convert.ToDecimal(TXT_Tip.Text);
            foreach (var x in orderList)
            {
                if (x.MenuItemID >= 29 && x.MenuItemID <= 43)
                {
                    Btw = x.Price * Convert.ToDecimal(0.21);
                    totalPriceBtwAdd = totalPrice * Convert.ToDecimal(1.21);
                    totaalprijsWithoutBTW = x.Price * Convert.ToDecimal(1.21);
                }
                else
                {
                    Btw = x.Price * Convert.ToDecimal(0.06);
                    totalPriceBtwAdd = totalPrice * Convert.ToDecimal(1.06);
                    totaalprijsWithoutBTW = x.Price * Convert.ToDecimal(1.06);
                }
                FinalTotaal += totaalprijsWithoutBTW;
                TotaalBTW += Btw;
            }
            priceLabelPayment.Text = pricePlaceHolder + FormatPrice(FinalTotaal + tip);
            LBL_ShwBtw.Text = TotaalBTW.ToString("€ 0.00");

            return (FormatPrice(FinalTotaal + tip), TotaalBTW.ToString("€ 0.00"));
        }

        private void SubmitReceedBTN_Click(object sender, EventArgs e)
        {
            if (!booleanTableIsClicked) {
                MessageBox.Show("Select an table!");
                return;
            }

            if (Status == string.Empty)
            {
                MessageBox.Show("Select an payment method!");
                return;
            }
            (string FinalTotaal, string TotaalBTW) = calcPrice();

            if (Status == "CreditCard")
                MessageBox.Show("Insert CreditCard, the btw is " + TotaalBTW + " and the total price is " + FinalTotaal);
            if (Status == "Cash")
                MessageBox.Show("Hand over the cash, the btw is " + TotaalBTW + " and the total price is " + FinalTotaal);
            if (Status == "Visa")
                MessageBox.Show("Insert Visa, the btw is " + TotaalBTW + " and the total price is " + FinalTotaal);

            int orderId = tableService.getSingleOrder(table.TableId).OrderID;
            tableService.deleteTableOrder(table.TableId, orderId);
            dispayTables();
            ClearDataGridView(dataGridView1);
            LBL_ShwBtw.Text = string.Empty;
            this.booleanTableIsClicked = false;
        }

        public string FormatPrice(decimal price)
        {
            return string.Format("{0:C}", price);
        }

        private void PaymentCashBtn_Click(object sender, EventArgs e)
        {
            Status = "Cash";
        }

        private void PaymentCardBtn_Click(object sender, EventArgs e)
        {
            Status = "Card";
        }

        private void PaymentVisaBtn_Click(object sender, EventArgs e)
        {
            Status = "Visa";
        }
    }
}
