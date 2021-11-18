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

    public class ClientArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = Client_Dal.GetDataTable();

            DataRow dataRow;
            Client curClient;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curClient = new Client(dataRow);
                this.Add(curClient);
            }
        }

        public ClientArr Filter(int id, string lastName, string email) //checks if clients exists, then moves the ones that exist into new array
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {
                client = (this[i] as Client);
                if (

                    (id == 0 || client.id == id) &&
                    client.LastName.ToLower().StartsWith(lastName.ToLower()) &&
                    (client.Email.ToString()).Contains(email)


                    )
                    clientArr.Add(client);
            }
            return clientArr;
        }
        public bool DoesExist(BackgroundMA curBackgroundMA)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Client).BackgroundMA.Id == curBackgroundMA.Id)
                    return true;

            return false;
        }

    }
}
