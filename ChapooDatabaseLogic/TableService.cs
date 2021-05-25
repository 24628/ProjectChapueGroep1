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
    }
}
