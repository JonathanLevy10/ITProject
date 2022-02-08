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
        public OrderArr Filter(int id, Client client, DateTime date) //checks if clients exists, then moves the ones that exist into new array
        {
            OrderArr orderArr = new OrderArr();
            Order order;
            for (int i = 0; i < this.Count; i++)
            {
                order = (this[i] as Order);
                if (

                    (id == 0 || order.id == id) &&
                    order.LastName.ToLower().StartsWith(lastName.ToLower()) &&
                    (client.Email.ToString()).Contains(date)


                    )
                    orderArr.Add(order);
            }
            return orderArr;
        }
    }
}
