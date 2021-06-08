using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapooDatabaseModel;

namespace ChapooDatabaseDal
{
    public class TableDAO : Base
    {
        public List<Table> getAllTables()
        {
            string query = "SELECT TableId, [Status], [SeatPlaces] FROM [Tables]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // return a list with drinks
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table(
                    Convert.ToInt32(dr["TableId"]),
                    dr["Status"].ToString(),
                    Convert.ToInt32(dr["SeatPlaces"])
                );
                tables.Add(table);
            }
            return tables;
        }

        public List<MenuItem> getMenuCard()
        {
            string query = "SELECT [MenuItemID], MenuName, Price from MenuItem;";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // return a list with drinks
            return ReadTablesMenuCard(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTablesMenuCard(DataTable dataTable)
        {
            List<MenuItem> menuItemList = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem(
                    Convert.ToInt32(dr["MenuItemID"]),
                    dr["MenuName"].ToString(),
                    Convert.ToDecimal(dr["Price"])
                );
                menuItemList.Add(item);
            }
            return menuItemList;
        }

        public int ItemExist(int id)
        {
            string query = "SELECT COUNT(*) FROM MenuItem WHERE MenuID = @id";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter pid = new SqlParameter("@id", SqlDbType.VarChar) { Value = id };
            sqlParameters[0] = pid;

            return ExecuteCountInteger(query, sqlParameters);
        }

        public void createTableOrder(int TableID, int EmployeeID)
        {
            DateTime myDateTime = DateTime.Now;
            float sqlFormattedDate = myDateTime.Ticks;
            string description = "Geen notitie nog!";

            string query = "INSERT INTO [Order] (TableID, EmployeeID, TimeOrder, OrderRemark) VALUES (@tableId, @employeeId, @timeStamp, @description)";

            // array with 4 parameters
            SqlParameter[] sqlParameters = new SqlParameter[4];

            SqlParameter ptid = new SqlParameter("@tableId", SqlDbType.Int) { Value = TableID };
            sqlParameters[0] = ptid;

            SqlParameter peid = new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = EmployeeID };
            sqlParameters[1] = peid;

            SqlParameter pts = new SqlParameter("@timeStamp", SqlDbType.VarChar) { Value = sqlFormattedDate };
            sqlParameters[2] = pts;

            SqlParameter pdes = new SqlParameter("@description", SqlDbType.VarChar) { Value = description };
            sqlParameters[3] = pdes;

            // execute query
            ExecuteEditQuery(query, sqlParameters);

            string thirdQuery = "UPDATE [Tables] SET Status = 'occupied' WHERE TableID = @TableId";
            SqlParameter[] thirdSqlParameters = new SqlParameter[1];

            SqlParameter thirdOrderId = new SqlParameter("@TableId", SqlDbType.Int) { Value = TableID };
            thirdSqlParameters[0] = thirdOrderId;

            ExecuteEditQuery(thirdQuery, thirdSqlParameters);
        }

        public void deleteTableOrder(int TableID, int OrderId)
        {
            string query = "DELETE FROM [OrderItem] WHERE OrderID = @OrderId";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter orderId = new SqlParameter("@OrderId", SqlDbType.Int) { Value = OrderId };
            sqlParameters[0] = orderId;

            ExecuteEditQuery(query, sqlParameters);

            string secondQuery = "DELETE FROM [Order] WHERE OrderID = @OrderId";
            SqlParameter[] secondSqlParameters = new SqlParameter[1];

            SqlParameter secondOrderId = new SqlParameter("@OrderId", SqlDbType.Int) { Value = OrderId };
            secondSqlParameters[0] = secondOrderId;

            ExecuteEditQuery(secondQuery, secondSqlParameters);

            string thirdQuery = "UPDATE [Tables] SET Status = 'Free' WHERE TableID = @TableId";
            SqlParameter[] thirdSqlParameters = new SqlParameter[1];

            SqlParameter thirdOrderId = new SqlParameter("@TableId", SqlDbType.Int) { Value = TableID };
            thirdSqlParameters[0] = thirdOrderId;

            ExecuteEditQuery(thirdQuery, thirdSqlParameters);
        }

        public int CheckIfTableExist(int id)
        {
            string query = "SELECT COUNT(*) FROM[Order] WHERE TableID = @id";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter pid = new SqlParameter("@id", SqlDbType.Int) { Value = id };
            sqlParameters[0] = pid;

            return ExecuteCountInteger(query, sqlParameters);
        }

        public Order getSingleOrder(int TableId)
        {
            // the query for the database, selecting [type], amount, price, alcohol FROM drinks WHERE amount > 1 AND price > 1.00
            string query = "SELECT OrderID, TableID, EmployeeID, TimeOrder, OrderRemark FROM [Order] WHERE TableID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter pid = new SqlParameter("@id", SqlDbType.Int) { Value = TableId };
            sqlParameters[0] = pid;

            return ReadTablesForOneOrder(ExecuteSelectQuery(query, sqlParameters));
        }

        private Order ReadTablesForOneOrder(DataTable dataTable)
        {
            Order er = new Order(
                Convert.ToInt32(dataTable.Rows[0]["OrderID"]),
                Convert.ToInt32(dataTable.Rows[0]["TableID"]),
                Convert.ToInt32(dataTable.Rows[0]["EmployeeID"]),
                dataTable.Rows[0]["TimeOrder"].ToString(),
                dataTable.Rows[0]["OrderRemark"].ToString()
            );
            return er;
        }

        public void AddMenuItemToOrder(int MenuItemId, int OrderItemId)
        {
            string query = "INSERT INTO [OrderItem] (MenuItemID, OrderID) VALUES (@MenuItemId, @OrderID)";

            // array with 4 parameters
            SqlParameter[] sqlParameters = new SqlParameter[2];

            SqlParameter pmid = new SqlParameter("@MenuItemId", SqlDbType.Int) { Value = MenuItemId };
            sqlParameters[0] = pmid;

            SqlParameter peoid = new SqlParameter("@OrderID", SqlDbType.Int) { Value = OrderItemId };
            sqlParameters[1] = peoid;
            // execute query
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderItem> getMenuItemBelongingTowardsOrder(int OrderID)
        {
            // the query for the database, selecting [type], amount, price, alcohol FROM drinks WHERE amount > 1 AND price > 1.00
            string query = "SELECT * FROM MenuItem JOIN[OrderItem] ON MenuItem.MenuItemID =[OrderItem].MenuItemID Where OrderID = @OrderID";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter pid = new SqlParameter("@OrderID", SqlDbType.Int) { Value = OrderID };
            sqlParameters[0] = pid;

            return ReadTablesForOneOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadTablesForOneOrderItems(DataTable dataTable)
        {

            List<OrderItem> oList = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem oItem = new OrderItem(
                    Convert.ToInt32(dr["ID"]),
                    Convert.ToInt32(dr["MenuItemID"]),
                    Convert.ToInt32(dr["MenuID"]),
                    Convert.ToInt32(dr["OrderID"]),
                    dr["MenuName"].ToString(),
                    Convert.ToDecimal(dr["Price"])
                );
                oList.Add(oItem);
            }
            return oList;
        }

        public int OrderItemExist(int id, int OrderId)
        {
            string query = "SELECT COUNT(*) FROM OrderItem WHERE ID = @id AND OrderID = @OrderID";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            SqlParameter pid = new SqlParameter("@id", SqlDbType.VarChar) { Value = id };
            sqlParameters[0] = pid;
            
            SqlParameter poid = new SqlParameter("@OrderID", SqlDbType.VarChar) { Value = OrderId };
            sqlParameters[1] = poid;

            return ExecuteCountInteger(query, sqlParameters);
        }

        public void RemoveMenuItemToOrder(int id)
        {
            string query = "DELETE FROM OrderItem WHERE ID = @id";

            // array with 4 parameters
            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter pid = new SqlParameter("@id", SqlDbType.Int) { Value = id };
            sqlParameters[0] = pid;

            // execute query
            ExecuteEditQuery(query, sqlParameters);
        }


        public List<OrderItem> getReceerdOrderForTableById(int tableId)
        {
            string query = "SELECT * From [Order] JOIN [OrderItem] as oi on[Order].OrderID = oi.OrderId JOIN [MenuItem] as mi on oi.MenuItemID = mi.MenuItemID Where [Order].TableID = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter pid = new SqlParameter("@tableId", SqlDbType.Int) { Value = tableId };
            sqlParameters[0] = pid;

            return ReadTablesForOneOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
