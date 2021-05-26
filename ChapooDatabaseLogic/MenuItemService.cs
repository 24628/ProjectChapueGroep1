using System;
using System.Collections.Generic;
using System.Text;
using ChapooDatabaseDal;
using ChapooDatabaseModel;

namespace ChapooDatabaseLogic
{
    public class MenuItemService
    {
        readonly ChapooDatabaseDal.ItemDAO dao = new ItemDAO();

        public List<MenuItem> GetAllItems() 
        {
            return dao.CheckItems();
        }
    }
}
