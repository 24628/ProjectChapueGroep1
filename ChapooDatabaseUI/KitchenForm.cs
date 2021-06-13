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
    public partial class KitchenForm : BaseForm
    {
        private const int size = 120;
        private const int padding = 18;

        private TableService tableService = new TableService();
        private List<Table> tables;
        private List<OrderItem> orderList;
        private Table SelectedTable = null;
        public KitchenForm()
        {
            InitializeComponent();
        }

        private void UpdateTableStatusForm_Click(object sender, EventArgs e)
        {
            if(this.SelectedTable == null)
            {
                MessageBox.Show("No table selected");
            }
            string status = (string)comboBox1.SelectedValue;
            int tableId = this.SelectedTable.TableId;

            tableService.updateTableStatus(tableId, status);

            dispayTables();
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            dispayTables();
            displayComboBox();
        }

        private void displayComboBox()
        {
            List<TableStatus> tableStatus = new List<TableStatus>();
            tableStatus.Add(new TableStatus() { Text = "Order", Value = "Order" });
            tableStatus.Add(new TableStatus() { Text = "Pickup", Value = "Pickup" });

            comboBox1.DataSource = tableStatus;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void dispayTables()
        {
            KitchenFormOrderFlowLayout.Controls.Clear();
            KitchenFormPickUpFlowLayout.Controls.Clear();

            this.tables = tableService.getAllTablesForKitchen();
            foreach (Table table in this.tables)
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
                button.Click += new EventHandler(Table_Click);

                switch (table.Status.ToLower())
                {
                    case "order":
                        KitchenFormOrderFlowLayout.Controls.Add(button);
                        break;
                    case "pickup":
                        KitchenFormPickUpFlowLayout.Controls.Add(button);
                        break;
                }
            }
        }

        private string getTableStatus(Table table)
        {
            return table.Status;
        }

        private void Table_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.SelectedTable = (Table)button.Tag;

            this.orderList = tableService.getReceerdOrderForTableById(this.SelectedTable.TableId);

            ClearDataGridView(dataGridView1);
            generateGridLayout(dataGridView1, new string[] { "id", "Naam", "Price" });

            foreach (var item in orderList)
            {
                FillDataInGridView(dataGridView1, item.dataGrid(item));
            }
        }
    }
}
