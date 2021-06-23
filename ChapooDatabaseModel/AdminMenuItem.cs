using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class AdminMenuItem : MenuItem
    {
        public int menuId;

        public AdminMenuItem(int MenuItemId, string name, decimal price, int v2) 
            : base (MenuItemId, name, price)
        {
            this.menuId = v2;
        }
    }
}
