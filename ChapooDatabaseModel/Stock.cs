using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class Stock
    {
        public readonly int StockID;
        public readonly int MenuItemID;
        public readonly string MenuName;
        public readonly int Amount;

        public Stock(int v1, int v2, int v3)
        {
            this.StockID = v1;
            this.MenuItemID = v2;
            this.Amount = v3;
        }

        public Stock(int v1, int v2, string v3, int v4)
        {
            this.StockID = v1;
            this.MenuItemID = v2;
            this.MenuName = v3;
            this.Amount = v4;
        }
    }
    
}
