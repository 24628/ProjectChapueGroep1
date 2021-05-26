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

