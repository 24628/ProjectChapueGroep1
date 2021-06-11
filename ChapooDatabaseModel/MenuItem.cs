using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class MenuItem
    {
        public readonly int MenuItemID;
        public readonly int MenuID;
        public readonly string MenuName;
        public readonly int Price;

        public MenuItem(int v1, int v2, string v3, int v4)
        {
            this.MenuItemID = v1;
            this.MenuID = v2;
            this.MenuName = v3;
            this.Price = v4;
        }
    }
}
