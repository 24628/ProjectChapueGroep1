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
            try
            {
                return dao.CheckItems();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            };
        }
        public void UpdateMenuItem(int MenuID, string MenuName, decimal Price)
        {
            try
            {
                dao.UpdateMenuItem(MenuID, MenuName, Price);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void AddMenuItem(int MenuID, string MenuName, decimal Price)
        {
            try
            {
                dao.AddMenuItem(MenuID, MenuName, Price);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteMenuItem(int MenuItemID)
        {
            try
            {
                dao.VerwijderMenuItem(MenuItemID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
