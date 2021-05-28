using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class MenuItem
    {
        private int Id;
        private string Name;
        private decimal Price;

        public MenuItem(int v1, string v2, decimal v3)
        {
            this.Id = v1;
            this.Name = v2;
            this.Price = v3;
        }

        public string[] dataGrid(MenuItem m)
        {
            return new string[] {
                m.Id.ToString(),
                m.Name,
                string.Format("{0:C}", m.Price/100)
            };
        }
    }
}
