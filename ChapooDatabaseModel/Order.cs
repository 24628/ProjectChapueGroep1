using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class Order
    {
        public int OrderID;
        public int TableID;
        public int EmployeeID;
        public string TimeOrder;
        public string OrderRemark;

        public Order(int v1, int v2, int v3, string v4, string v5)
        {
            this.OrderID = v1;
            this.TableID = v2;
            this.EmployeeID = v3;
            this.TimeOrder = v4;
            this.OrderRemark = v5;
        }
    }
}
