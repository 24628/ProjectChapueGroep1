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
//<<<<<<< HEAD
            //this.MenuItemID = v1;
            //this.MenuID = v2;
            //this.MenuName = v3;
            //this.Price = v4;
//=======
            this.Id = v1;
            this.Name = v2;
            this.Price = v3;
        }

        public string[] dataGrid(MenuItem m)
        {
            return new string[] {
                m.Id.ToString(),
                m.Name,
                string.Format("{0:C}", m.Price)
            };
//>>>>>>> 837202a168db295a6b325955762b9c0b29bc8029
        }
    }
}
