using System;
using System.Collections.Generic;
using System.Text;
using ChapooDatabaseDal;
using ChapooDatabaseModel;

namespace ChapooDatabaseLogic
{
    public class TableService
    {
        readonly ChapooDatabaseDal.TableDAO dao = new TableDAO();

        public List<Table> GetAllTables()
        {
            return dao.getAllTables();
        }

        public List<MenuItem> getMenuCard()
        {
            return dao.getMenuCard();
        }

        public bool ItemExist(int e)
        {
            if (dao.ItemExist(e) == 1)
                return true;
            else
                return false;
        }

        public void createTableOrder(int tid, int eid)
        {
            dao.createTableOrder(tid, eid);
        }

        public bool CheckIfTableExistAndHasAnOrder(int id)
        {
            if (dao.CheckIfTableExist(id) == 1)
                return true;
            else
                return false;
        }
        
        public bool OrderItemExist(int id, int OrderId)
        {
            if (dao.OrderItemExist(id, OrderId) == 1)
                return true;
            else
                return false;
        }

        public Order getSingleOrder(int TableId)
        {
            return dao.getSingleOrder(TableId);
        }

        public void AddMenuItemToOrder(int e, int b)
        {
            dao.AddMenuItemToOrder(e, b);
        }
        
        public void removeMenuItemToOrder(int e)
        {
            dao.RemoveMenuItemToOrder(e);
        }

        public List<OrderItem> getMenuItemBelongingTowardsOrder(int e)
        {
            return dao.getMenuItemBelongingTowardsOrder(e);
        }
    }
}
