using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class MenuItem
    {
        public int Id;
        public string Name;
        public decimal Price;

        public MenuItem(int v1, string v2, decimal v3)
        {
            this.Id = v1;
            this.Name = v2;
            this.Price = v3;
        }
    }
}
