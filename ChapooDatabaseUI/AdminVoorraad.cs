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
        public AdminVoorraad()
        {
            InitializeComponent();
            displayGrid();
        }
        
        private void displayGrid()
        {

            ClearDataGridView(AdminVoorraadGrid);
            generateGridLayout(AdminVoorraadGrid, new string[] { "StockID", "MenuItemID", "MenuName", "Amount" });

            List<Stock> emp = stockService.GetAllStock();
            foreach (var e in emp)
            {
                FillDataInGridView(AdminVoorraadGrid, e.dataGrid(e));
            }
        }

        private void BTN_STUpdate_Click(object sender, EventArgs e)
        {
            int StockID = Int32.Parse(TXTB_STStockIDs.Text);
            int MenuItemID = Int32.Parse(TXTB_STMenuIDs.Text);
           
            int Amount = Int32.Parse(TXTB_STAmounts.Text);
            stockService.UpdateStock(StockID, MenuItemID, Amount);
            MessageBox.Show("De Stock wijzigingen zijn doorgevoerd", "Item Wijzigingen!", MessageBoxButtons.OK);
            displayGrid();
        }

        public void EmtyTextboxStock() // maak de textbox leeg naar gebruik
        {
            TXTB_STStockIDs.Text = string.Empty;
            TXTB_STMenuIDs.Text = string.Empty;
            TXTB_STAmounts.Text = string.Empty;
        }

        private void BTN_STAdd_Click(object sender, EventArgs e)
        {
            int MenuItemID = Int32.Parse(TXTB_STMenuIDs.Text);
            int Amount = Int32.Parse(TXTB_STAmounts.Text);
            stockService.AddStock(MenuItemID, Amount);
            MessageBox.Show("Stock toegevoegd", "Menu Item!", MessageBoxButtons.OK);
            EmtyTextboxStock();
            displayGrid();
        }


        private void BTN_STDelete_Click(object sender, EventArgs e)
        {
            int StockID = int.Parse(TXTB_STStockIDs.Text.ToString());
            stockService.DeleteStock(StockID);

            MessageBox.Show("Item in Stock Gedelete", "Voorraad!", MessageBoxButtons.OK);
            displayGrid();
        }

        private void BTN_STTerug_Click(object sender, EventArgs e)
        {
            showNewForm(new AdministratorForm(), this, getCurrentUser());
        }
    }
}
