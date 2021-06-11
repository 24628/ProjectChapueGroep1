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
        StockService stockService;
        //List<string> variable;
        public AdminVoorraad()
        {
            stockService = new StockService();
          //  variable = new List<string>();
            InitializeComponent();
        }
       
        private void AdminVoorraadGrid_CellContentClick(object sender, EventArgs e)
        {
            AdminVoorraadGrid.Columns.Add("StockID", "StockID");
            AdminVoorraadGrid.Columns.Add("MenuID", "MenuID");
            AdminVoorraadGrid.Columns.Add("Amount", "Amount");
            foreach (Stock stock in stockService.GetAllStock())
            {
            //    variable = new List<string> { stock.StockID.ToString(), stock.MenuID.ToString(), stock.Amount.ToString() };
                

               string[] row = { stock.StockID.ToString(), stock.MenuID.ToString(), stock.Amount.ToString()};
                AdminVoorraadGrid.Rows.Add(row);
                
            }
        }
        private void BTN_STUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AdminVoorraadGrid.Rows.Count - 1; i++)
            {
                //int StockID = int.Parse(AdminVoorraadGrid.Rows[i].Cells[0].Value.ToString());
                int MenuID = int.Parse(AdminVoorraadGrid.Rows[i].Cells[0].Value.ToString());
                int Amount = int.Parse(AdminVoorraadGrid.Rows[i].Cells[1].Value.ToString());
                stockService.UpdateStock(MenuID, Amount);
            }
            MessageBox.Show("De Voorraad wijzigingen zijn doorgevoerd", "Employee Wijzigingen!", MessageBoxButtons.OK);
        }
        public bool StockCheck(int StockID) // check of de Employee al bestaat
        {
            foreach (Stock stock in stockService.GetAllStock())
            {
                if (StockID == stock.StockID)
                {
                    return true;
                }
            }
            return false;
        }

        public void EmtyTextbox() // maak de textbox leeg naar gebruik
        {
            TXTB_STStockIDs.Text = string.Empty;
            TXTB_STMenuIDs.Text = string.Empty;
            TXTB_STAmounts.Text = string.Empty;
        }

        private void BTN_STAdd_Click(object sender, EventArgs e)
        {
            //int StockID = int.Parse(TXTB_STStockID.Text.ToString());
            int MenuID = int.Parse(TXTB_STMenuIDs.Text.ToString());
            int Amount = int.Parse(TXTB_STAmounts.Text.ToString());
           
            stockService.AddStock(MenuID, Amount);
            MessageBox.Show("Item in Stock toegevoegd", "Employee!", MessageBoxButtons.OK);
            EmtyTextbox();
        }


        private void BTN_STDelete_Click(object sender, EventArgs e)
        {
            int StockID = int.Parse(TXTB_STStockIDs.Text.ToString());

            //int Index = AdminVoorraadGrid.CurrentCell.RowIndex;

            //AdminVoorraadGrid.Rows.RemoveAt(Index);
            stockService.DeleteStock(StockID);

            MessageBox.Show("Item in Stock Gedelete", "Voorraad!", MessageBoxButtons.OK);
        }
    }
}
