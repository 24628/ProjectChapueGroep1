using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Color setTableColor(string status){


            int x = 0, y = 0, z = 0;

            switch (status.ToLower())
            {
                case "free":
                    x = 0; y = 255; z = 42;
                    break;
                case "reservation":
                    x = 255; y = 0; z = 0;
                    break;
                case "order":
                    x = 255; y = 255; z = 25;
                    break;
                case "pickup":
                    x = 255; y = 140; z = 25;
                    break;
            }

            return Color.FromArgb(x, y, z);
        }
    }
}
