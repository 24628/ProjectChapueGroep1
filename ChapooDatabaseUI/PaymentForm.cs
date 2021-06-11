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
            Table table = (Table)button.Tag;

            this.orderList = tableService.getReceerdOrderForTableById(table.TableId);

            ClearDataGridView(dataGridView1);
            generateGridLayout(dataGridView1, new string[] { "id", "Naam", "Price" });

            totalPrice = 0;
            foreach (var item in orderList)
            {
                FillDataInGridView(dataGridView1, item.dataGrid(item));
                totalPrice += item.Price;
            }

            priceLabelPayment.Text = pricePlaceHolder + FormatPrice(totalPrice);
        }

        private void SubmitReceedBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert card the total price is " + FormatPrice(totalPrice));
        }


        public string FormatPrice(decimal price)
        {
            return string.Format("{0:C}", price);
        }
    }
}
