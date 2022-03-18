using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFP_GOS.DAL;

namespace WFP_GOS.BL
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
        public OrderArr Filter(int id, DateTime fromDate, DateTime toDate, string client)
        {
            OrderArr orderArr = new OrderArr();
            Order order;
            for (int i = 0; i < this.Count; i++)
            {
                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                order = (this[i] as Order);
                if
                (
                (id == 0 || order.Id == id)
                && (order.Client.FullName.Contains(client))
                && (order.Date >= fromDate && order.Date <= toDate)
                )
                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר
                    orderArr.Add(order);
            }
            return orderArr;
        }
        public Order GetOrderWithMaxId()
        {
            Order maxOrder = new Order();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).Id > maxOrder.Id)
                    maxOrder = this[i] as Order;

            return maxOrder;
        }
        
    }
}
