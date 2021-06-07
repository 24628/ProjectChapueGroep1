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

        private TableService tableService = new TableService();
        private List<Table> TableList;

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


                button.Text += SetTableStatus(table);

                // Display table colour based on status
                button.BackColor = table.Status != "Free" ? Color.FromArgb(255, 104, 107) : Color.FromArgb(132, 220, 198);

                if(table.Status != "Free")
                    button.Click += new EventHandler(Table_Click);

                TableHolderFlowLayout.Controls.Add(button);
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


            MessageBox.Show(table.TableId.ToString());

        }
    }
}
