using ChapooDatabaseLogic;
using ChapooDatabaseModel;
using ChapooDatabaseUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapooDatabaseUI
{
    public partial class OrderForm : BaseForm
    {
        private const int size = 120;
        private const int padding = 18;

        private TableService tableService = new TableService();
        private List<Table> TableList;

        public OrderForm()
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


                button.Text += SetTableStatus(table);

                // Display table colour based on status
                button.BackColor = table.Status != "Free" ? Color.FromArgb(255, 104, 107) : Color.FromArgb(132, 220, 198);

                button.Click += new EventHandler(Table_Click);
                flowLayoutTableContainer.Controls.Add(button);
            }
        }

        private string SetTableStatus(Table table)
        {
            return table.Status;
        }

        private void Table_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Table table = (Table)button.Tag;
            showNewTableOrder(this, getCurrentUser(), table.TableId);

            //if (!table.Occupied) tableService.ChangeOccupation(table, true);

            //DisplayMenuPanel(table);
        }
    }
}
