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
        public List<AdminMenuItem> CheckItems()
        {
            string query = "SELECT MenuItemID, MenuID, MenuName, Price FROM MenuItem";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        
        public List<Menu> getMenuTypes()
        {
            string query = "SELECT * FROM [Menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenuTypes(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateMenuItem(int MenuItemID, string MenuName, decimal Price)
        {
            string query = $"UPDATE [MenuItem] SET MenuName = '{MenuName}', Price = '{Price}' WHERE MenuItemID = '{MenuItemID}'";
            SqlParameter[] sqlParameter = new SqlParameter[3];
            sqlParameter[0] = new SqlParameter("MenuItemID", MenuItemID);
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
            string query = $" DELETE FROM [MenuItem] Where MenuItemID = '{MenuItemID}'";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("MenuItemID", MenuItemID);
            ExecuteEditQuery(query, sqlParameter);
        }
        private List<AdminMenuItem> ReadTables(DataTable dataTable)
        {
            List<AdminMenuItem> menuItems = new List<AdminMenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                AdminMenuItem menu = new AdminMenuItem(
                    Convert.ToInt32(dr["MenuItemID"]),
                    dr["MenuName"].ToString(),
                    Convert.ToDecimal(dr["Price"]),
                    Convert.ToInt32(dr["MenuID"])
                );
                menuItems.Add(menu);
            }
            return menuItems;
        }

        private List<Menu> ReadMenuTypes(DataTable dataTable)
        {
            List<Menu> ls = new List<Menu>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menu a = new Menu(
                    Convert.ToInt32(dr["MenuID"]),
                    dr["Type"].ToString()
                );
                ls.Add(a);
            }
            return ls;
        }
    }
}

