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
            string query = "SELECT StockID, MenuID, Amount FROM Stock";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateStock(int MenuID, int Amount)
        {
            string query = $"Update [Stock] = Stock.MenuID = {MenuID}, Stock.Amount = '{Amount}', WHERE Stock";
            SqlParameter[] sqlParameter = new SqlParameter[2];
            
            sqlParameter[0] = new SqlParameter("Stock", MenuID);
            sqlParameter[1] = new SqlParameter("Stock", Amount);
            ExecuteEditQuery(query, sqlParameter);
        }
        public void AddStock(int MenuID, int Amount)
        {
            string query = $"insert into [Stock] (MenuID, Amount) VALUES ('{MenuID}','{Amount}')";
            SqlParameter[] sqlParameter = new SqlParameter[2];
            //sqlParameter[0] = new SqlParameter("MenuItemID", StockID);
            sqlParameter[0] = new SqlParameter("MenuID", MenuID);
            sqlParameter[1] = new SqlParameter("MenuName", Amount);
            ExecuteEditQuery(query, sqlParameter);
        }
        public void DeleteStock(int StockID)
        {
            string query = $"Delete FROM [Stock] WHERE StockID = '{StockID}'";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            sqlParameter[0] = new SqlParameter("StockID", StockID);
            //sqlParameter[1] = new SqlParameter("MenuID", MenuID);
            //sqlParameter[2] = new SqlParameter("MenuName", Amount);
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
                Convert.ToInt32(dr["Amount"])
                );
                stockList.Add(stclist);
            }
            return stockList;
        }
    }
}
