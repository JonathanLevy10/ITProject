using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFP_GOS.DAL;

namespace WFP_GOS.BL
{
    class CompClientArr : ArrayList
    {
        public CompClientArr Filter(Comp comp) //checks if compclient exists, then moves the ones that exist into new array
        {
            CompClientArr compClientArr = new CompClientArr();
            CompClient compClient;
            for (int i = 0; i < this.Count; i++)
            {
                compClient = (this[i] as CompClient);
                if (compClient.Comp.Id == comp.Id)
                    compClientArr.Add(compClient);
            }
            return compClientArr;
        }
        public CompClientArr Filter(Client curClient) //checks if compclient exists, then moves the ones that exist into new array
        {
            CompClientArr compClientArr = new CompClientArr();
            CompClient compClient;
            for (int i = 0; i < this.Count; i++)
            {
                compClient = (this[i] as CompClient);
                if (compClient.Client.id == curClient.id)
                    compClientArr.Add(compClient);
            }
            return compClientArr;
        }
        public bool Insert()
        {

            // מוסיפה את אוסף המוצרים להזמנה למסד הנתונים

            CompClient compClient = null;
            for (int i = 0; i < this.Count; i++)
            {
                compClient = (this[i] as CompClient);
                if (!compClient.Insert())
                    return false;
            }
            return true;
        }
        public bool Delete()
        {

            //מוחקת את אוסף המוצרים להזמנה ממסד הנתונים

            for (int i = 0; i < this.Count; i++)
                (this[i] as CompClient).Delete();
            return true;
        }
        public void Fill()
        {
            DataTable dataTable = CompClient_Dal.GetDataTable();

            DataRow dataRow;
            CompClient curCompClient;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCompClient = new CompClient(dataRow);
                this.Add(curCompClient);
            }
        }
        public ClientArr GetClientArr()
        {

            //מחזירה את אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            ClientArr clientArr = new ClientArr();
            for (int i = 0; i < this.Count; i++)
                clientArr.Add((this[i] as CompClient).Client);
            return clientArr;
        }
        public bool DoesExist(Client curClient)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as CompClient).Client.id == curClient.id)
                    return true;

            return false;
        }
    }
}
