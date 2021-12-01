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

    public class BackgroundMAArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = BackgroundMA_Dal.GetDataTable();

            DataRow dataRow;
            BackgroundMA curBackgroundMA; //Do I change this?

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curBackgroundMA = new BackgroundMA(dataRow);
                this.Add(curBackgroundMA);
            }
        }

        public BackgroundMAArr Filter(int id, string BackgroundMA) //checks if clients exists, then moves the ones that exist into new array
        {
            BackgroundMAArr backgroundMAArr = new BackgroundMAArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {
                client = (this[i] as Client);
                if (

                    (id == 0 || client.id == id) &&
                    client.BackgroundMA.Name.ToLower().StartsWith(BackgroundMA.ToLower()) 


                    )
                    backgroundMAArr.Add(backgroundMAArr);
            }
            return backgroundMAArr;
        }

        public bool IsContains(string BackgroundMA_Name)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as BackgroundMA).Name == BackgroundMA_Name)
                    return true;

            return false;
        }

        public BackgroundMA GetBackgroundMAWithMaxId()
        {
            BackgroundMA maxBackgroundMA = new BackgroundMA();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as BackgroundMA).Id > maxBackgroundMA.Id)
                    maxBackgroundMA = this[i] as BackgroundMA;

            return maxBackgroundMA;
        }

    }
}
