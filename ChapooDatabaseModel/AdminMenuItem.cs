using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class AdminMenuItem : MenuItem
    {
        private int menuId;

        public AdminMenuItem(int MenuItemId, string name, decimal price, int v2) 
            : base (MenuItemId, name, price)
        {
            this.menuId = v2;
        }

        public string[] dataGrid(AdminMenuItem m)
        {
            return new string[] {
                m.menuId.ToString(),
                m.Id.ToString(),
                m.Name,
                string.Format("{0:C}", m.Price)
            };
        }
    }
}
