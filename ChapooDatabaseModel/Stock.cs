using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class Stock
    {
        public readonly int StockID;
        public readonly int MenuID;
        public readonly int Amount;
        
        public Stock(int v1, int v2, int v3)
        {
            this.StockID = v1;
            this.MenuID = v2;
            this.Amount = v3;
        }
    }
    
}
