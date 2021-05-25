using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapooDatabaseModel;

namespace ChapooDatabaseDal
{
    public class TableDAO : Base
    {
        public List<Table> getAllTables()
        {
            string query = "SELECT TableId, [Status], [SeatPlaces] FROM [Tables]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // return a list with drinks
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table(
                    Convert.ToInt32(dr["TableId"]),
                    dr["Status"].ToString(),
                    Convert.ToInt32(dr["SeatPlaces"])
                );
                tables.Add(table);
            }
            return tables;
        }
    }
}
