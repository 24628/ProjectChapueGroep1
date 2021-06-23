using SomerenDAL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Data;
using ChapooDatabaseModel;

namespace ChapooDatabaseDal
{
    public class StockDAO : Base
    {
        public List<Stock> CheckStock()
        {
            string query = "SELECT StockID, M.MenuItemID, MenuName, Amount FROM Stock AS S JOIN MenuItem AS M ON S.MenuItemID = M.MenuItemID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateStock(int StockID, int MenuItemID, int Amount)
        {
            string query = $"UPDATE [Stock] SET MenuItemID = '{MenuItemID}', Amount = '{Amount}' WHERE StockID = '{StockID}'";
            SqlParameter[] sqlParameter = new SqlParameter[3];
            sqlParameter[0] = new SqlParameter("StockID", StockID); 
            sqlParameter[1] = new SqlParameter("MenuItemID", MenuItemID);
            sqlParameter[2] = new SqlParameter("Amount", Amount);

            ExecuteEditQuery(query, sqlParameter);
        }
        public void AddStock(int MenuID, int Amount)
        {
            string query = $"insert into [Stock] (M.MenuItemID, Amount) VALUES ('{MenuID}','{Amount}')";
            SqlParameter[] sqlParameter = new SqlParameter[2];
            sqlParameter[0] = new SqlParameter("MenuID", MenuID);
            sqlParameter[1] = new SqlParameter("Amount", Amount);
            ExecuteEditQuery(query, sqlParameter);
        }
        public void DeleteStock(int StockID)
        {
            string query = $" DELETE FROM [Stock] Where StockID = '{StockID}'";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("StockID ", StockID);
            ExecuteEditQuery(query, sqlParameter);
        }
        private List<Stock> ReadTables(DataTable dataTable)
        {
            List<Stock> stockList = new List<Stock>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Stock stclist = new Stock(
                    Convert.ToInt32(dr["StockID"]),
                    Convert.ToInt32(dr["MenuItemID"]),
                    dr["MenuName"].ToString(),
                    Convert.ToInt32(dr["Amount"])
                );
                stockList.Add(stclist);
            }
            return stockList;
        }

        public Stock findStockWaarde(int menuItemId)
        {
            string query = "SELECT * from Stock Where MenuItemID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter paraName = new SqlParameter("@id", SqlDbType.Int) { Value = menuItemId };
            sqlParameters[0] = paraName;

            return getSignleStockWaarde(ExecuteSelectQuery(query, sqlParameters));
        }

        private Stock getSignleStockWaarde(DataTable dataTable)
        {
            Stock m = new Stock(
                Convert.ToInt32(dataTable.Rows[0]["StockId"]),
                Convert.ToInt32(dataTable.Rows[0]["MenuItemID"]),
                Convert.ToInt32(dataTable.Rows[0]["Amount"])
            );
            return m;
        }
    }
}
