using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooDatabaseModel
{
    public class Table
    {
        public int TableId;
        public string Status;
        public int SeatPlaces;

        public Table(int v1, string v2, int v3)
        {
            this.TableId = v1;
            this.Status = v2;
            this.SeatPlaces = v3;
        }
    }
}
