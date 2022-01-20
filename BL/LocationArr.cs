using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSignup.DAL;

namespace ClientSignup.BL
{

    public class LocationArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = Location_Dal.GetDataTable();

            DataRow dataRow;
            Location curLocation;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curLocation = new Location(dataRow);
                this.Add(curLocation);
            }
        }
        public LocationArr Filter(int id, string name)
        {
            LocationArr levelArr = new LocationArr(); //checks if level exists, then moves the ones that exist into new array
            Location level;
            for (int i = 0; i < this.Count; i++)
            {
                level = (this[i] as Location);
                if (
                    (id == 0 || level.Id == id) && level.Name.ToLower().StartsWith(name.ToLower()))
                    levelArr.Add(levelArr);
            }
            return levelArr;
        }
        public bool IsContains(string name)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Location).Name == name)
                    return true;

            return false;
        }
        public Location GetLocationWithMaxId()
        {
            Location maxLocation = new Location();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Location).Id > maxLocation.Id)
                    maxLocation = this[i] as Location;

            return maxLocation;
        }

    }
}
