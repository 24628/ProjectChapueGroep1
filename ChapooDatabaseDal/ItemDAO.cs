using SomerenDAL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ChapooDatabaseModel;

namespace ChapooDatabaseDal
{
    public class ItemDAO : Base
    {
        public List<MenuItem> CheckItems()
        {
            string query = "SELECT MenuItemID, MenuID, MenuName, Price FROM MenuItem";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateMenuItem(int MenuID, string MenuName, decimal Price)
        {
            string query = $"Update [MenuItem] set  MenuItem.MenuID = {MenuID}, MenuItem.MenuName = '{MenuName}', MenuItem.Price = '{Price}' WHERE MenuItem.MenuName = '{MenuName}'";
            SqlParameter[] sqlParameter = new SqlParameter[4];
            //sqlParameter[0] = new SqlParameter("MenuItemID", MenuItemID);
            sqlParameter[0] = new SqlParameter("MenuID", MenuID);
            sqlParameter[1] = new SqlParameter("MenuName", MenuName);
            sqlParameter[2] = new SqlParameter("Price", Price);
            ExecuteEditQuery(query, sqlParameter);
        }
        public void AddMenuItem(int MenuID, string MenuName, decimal Price) //no menuitem cause auto increment
        {
            string query = $"insert into [MenuItem] (MenuID, MenuName, Price) VALUES ('{MenuID}','{MenuName}','{Price}')";
            SqlParameter[] sqlParameter = new SqlParameter[3];
            sqlParameter[0] = new SqlParameter("MenuID", MenuID);
            sqlParameter[1] = new SqlParameter("MenuName", MenuName);
            sqlParameter[2] = new SqlParameter("Price", Price);
            ExecuteEditQuery(query, sqlParameter);
        }
        public void VerwijderMenuItem(int MenuItemID)
        {
            string query = $" DELETE MenuItemID FROM MenuItem Where MenuItemID = '{MenuItemID}'";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            sqlParameter[0] = new SqlParameter("MenuItemID", MenuItemID);
            //sqlParameter[1] = new SqlParameter("MenuID", MenuID);
            //sqlParameter[2] = new SqlParameter("MenuName", MenuName);
            //sqlParameter[3] = new SqlParameter("Price", Price);
            ExecuteEditQuery(query, sqlParameter);
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menu = new MenuItem(
                Convert.ToInt32(dr["MenuItemID"]),
                Convert.ToInt32(dr["MenuID"]),
                dr["MenuName"].ToString(),
                Convert.ToInt32(dr["Price"])
                );
                menuItems.Add(menu);
            }
            return menuItems;
        }
    }
}

