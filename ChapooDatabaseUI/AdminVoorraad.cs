using System;
using System.Collections; 
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
    public partial class AdminVoorraad : BaseForm
    {
        private StockService stockService = new StockService();
        private TableService tableService = new TableService();
        MenuItem selectedMenuItem;
        Stock selectedStock;

        public AdminVoorraad()
        {
            InitializeComponent();
            displayGrid();
        }
        
        private void displayGrid()
        {

            ClearDataGridView(AdminVoorraadGrid);
            generateGridLayout(AdminVoorraadGrid, new string[] {"MenuName", "Amount" });

            List<Stock> emp = stockService.GetAllStock();
            foreach (var e in emp)
            {
                FillDataInGridView(AdminVoorraadGrid, dataGrid(e));
            }
        }

        public string[] dataGrid(Stock m)
        {
            return new string[] {
                m.MenuName,
                m.Amount.ToString()
            };
        }

        private void BTN_STUpdate_Click(object sender, EventArgs e)
        {
            int Amount;

            if (!Int32.TryParse(TextBoxAmount.Text, out Amount))
            {
                MessageBox.Show("Correct stock amount in full integers!");
                return;
            }

            if(this.selectedStock == null)
            {
                MessageBox.Show("Selected An Item!");
                return;
            }
            Amount = Int32.Parse(TextBoxAmount.Text);
            stockService.UpdateStock(this.selectedStock.StockID, this.selectedMenuItem.Id, Amount);
            MessageBox.Show("De Stock: " + this.selectedMenuItem.Name + " is gezet naar: " + Amount, "Item Wijzigingen!", MessageBoxButtons.OK);
            displayGrid();
        }

        private void BTN_STTerug_Click(object sender, EventArgs e)
        {
            showNewForm(new AdministratorForm(), this, getCurrentUser());
        }

        private void AdminVoorraadGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Voor elke row in de grid loopen wij er door heen
            for (int row = 0; row < AdminVoorraadGrid.RowCount; row++)
            {
                //Kijken we er of een geselcteerde grid is
                if (AdminVoorraadGrid.SelectedRows.Count == 1)
                {
                    //Kijken grid row data cell value 1 gelijk staat aan de geselecteerde grid!
                    if (AdminVoorraadGrid.Rows[row].Cells[0] == AdminVoorraadGrid.SelectedRows[0].Cells[0])
                    {
                        string selectedMenuItemName = (string)AdminVoorraadGrid.SelectedRows[0].Cells[0].Value;
                        string stockWaarde = (string)AdminVoorraadGrid.SelectedRows[0].Cells[1].Value;
                        this.selectedMenuItem = tableService.findMenuItem(selectedMenuItemName);
                        this.selectedStock = stockService.findStockWaarde(this.selectedMenuItem.Id);
                    }
                }
            }
        }
    }
}
