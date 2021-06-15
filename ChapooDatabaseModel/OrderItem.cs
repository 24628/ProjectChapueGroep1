using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class OrderItem
    {
        public int ID;
        public int MenuItemID;
        public int MenuID;
        public int OrderID;
        public string MenuName;
        public decimal Price;
        public string date;

        public OrderItem(int v1, int v2, int v3, int v4, string v5, decimal v6)
        {
            this.ID = v1;
            this.MenuItemID = v2;
            this.MenuID = v3;
            this.OrderID = v4;
            this.MenuName = v5;
            this.Price = v6;
        }

        public string[] dataGrid(OrderItem m)
        {
            return new string[] {
                m.ID.ToString(),
                m.MenuName,
                string.Format("{0:C}", m.Price),
                m.date
            };
        }
    }
}
