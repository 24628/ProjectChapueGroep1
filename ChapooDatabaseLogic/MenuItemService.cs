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

        public List<AdminMenuItem> GetAllItems() 
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
        
        public List<Menu> getMenuTypes() 
        {
            try
            {
                return dao.getMenuTypes();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            };
        }
        public void UpdateMenuItem(int MenuItemID, string MenuName, decimal Price)
        {
            try
            {
                dao.UpdateMenuItem(MenuItemID, MenuName, Price);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateMenuItemType(int MenuItemID, int MenuId)
        {
            try
            {
                dao.UpdateMenuItemType(MenuItemID, MenuId);
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
