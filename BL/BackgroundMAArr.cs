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
            Location curLocation; //Do I change this?

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curLocation = new Location(dataRow);
                this.Add(curLocation);
            }
        }

        public LocationArr Filter(int id, string Location) //checks if clients exists, then moves the ones that exist into new array
        {
            LocationArr backgroundMAArr = new LocationArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {
                client = (this[i] as Client);
                if (

                    (id == 0 || client.id == id) &&
                    client.Location.Name.ToLower().StartsWith(Location.ToLower()) 


                    )
                    backgroundMAArr.Add(backgroundMAArr);
            }
            return backgroundMAArr;
        }

        public bool IsContains(string Location_Name)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Location).Name == Location_Name)
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
