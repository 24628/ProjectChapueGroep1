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
        private Table table = null;

        public PaymentForm()
        {
            InitializeComponent();
            dispayTables();
            displayComboBox();
        }

        private void displayComboBox()
        {
            List<PaymentMethod> pMed = new List<PaymentMethod>();
            pMed.Add(new PaymentMethod() { Text = "CreditCard", Value = "CreditCard" });
            pMed.Add(new PaymentMethod() { Text = "Cash", Value = "Cash" });
            pMed.Add(new PaymentMethod() { Text = "Visa", Value = "Visa" });

            comboBox1.DataSource = pMed;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
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
            Button button = (Button)sender;
            table = (Table)button.Tag;

            this.orderList = tableService.getReceerdOrderForTableById(table.TableId);

            ClearDataGridView(dataGridView1);
            generateGridLayout(dataGridView1, new string[] { "id", "Naam", "Price" });

            totalPrice = 0;
            foreach (var item in orderList)
            {
                FillDataInGridView(dataGridView1, item.dataGrid(item));
                totalPrice += item.Price;
            }
        }

        private void SubmitReceedBTN_Click(object sender, EventArgs e)
        {
            string status = (string)comboBox1.SelectedValue;
            decimal tip = 0.00m;
            if (textBox1.Text != string.Empty)
                tip = Convert.ToDecimal(textBox1.Text);
            priceLabelPayment.Text = pricePlaceHolder + FormatPrice(totalPrice + tip);

            if (status == "CreditCard")
                MessageBox.Show("Insert CreditCard, the total price is " + FormatPrice(totalPrice + tip));
            if (status == "Cash")
                MessageBox.Show("Hand over the cash, the total price is " + FormatPrice(totalPrice + tip));
            if (status == "Visa")
                MessageBox.Show("Insert Visa, the total price is " + FormatPrice(totalPrice + tip));

            int orderId = tableService.getSingleOrder(table.TableId).OrderID;
            tableService.deleteTableOrder(table.TableId, orderId);
            dispayTables();
        }


        public string FormatPrice(decimal price)
        {
            return string.Format("{0:C}", price);
        }

    }
}
