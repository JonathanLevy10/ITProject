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
    class OrderArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = Order_Dal.GetDataTable();

            DataRow dataRow;
            Order curOrder;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrder = new Order(dataRow);
                this.Add(curOrder);
            }
        }
        //Fix Filter
        public OrderArr Filter(int id, DateTime FromDate, DateTime ToDate, Client client)
        {
            OrderArr orderArr = new OrderArr();
            Order order;
            for (int i = 0; i < this.Count; i++)
            {
                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                order = (this[i] as Order);
                if
                (
                // מזהה 0 – כלומר, לא נבחר מזהה בסינון
                (id == 0 || order.Id == id) && (client == null || client.id == -1 || order.Client.id == client.id) && (order.Date >= FromDate && order.Date <= ToDate)
                )
                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר
                    orderArr.Add(order);
            }
            return orderArr;
        }
    }
}
