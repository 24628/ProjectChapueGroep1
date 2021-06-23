using System;
using System.Collections.Generic;
using System.Text;
using ChapooDatabaseDal;
using ChapooDatabaseModel;

namespace ChapooDatabaseLogic
{
    public class StockService
    {
        readonly ChapooDatabaseDal.StockDAO dao = new StockDAO();

        public List<Stock> GetAllStock()
        {
            try
            {
                return dao.CheckStock();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public void UpdateStock(int StockID, int MenuItemID, int Amount)
        {
            try
            {
                dao.UpdateStock(StockID, MenuItemID, Amount);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void AddStock(int MenuID, int Amount)
        {
            try
            {
                dao.AddStock(MenuID, Amount);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteStock(int StockID)
        {
            try
            {
                dao.DeleteStock(StockID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Stock findStockWaarde(int menuItemId)
        {
            return dao.findStockWaarde(menuItemId);
        }
    }
}
