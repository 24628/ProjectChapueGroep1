using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class Menu
    {

        public int Id;
        public string Type;

        public Menu(int v1, string v2)
        {
            this.Id = v1;
            this.Type = v2;
        }

        public virtual string[] dataGrid(Menu m)
        {
            return new string[] {
                m.Id.ToString(),
                m.Type,
            };
        }
    }
}
