using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSignup.DAL;

namespace ClientSignup.BL
{
    class OrderProductArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = OrderProduct_Dal.GetDataTable();

            DataRow dataRow;
            OrderProduct curOrderProduct;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrderProduct = new OrderProduct(dataRow);
                this.Add(curOrderProduct);
            }
        }

        public OrderProductArr Filter(Order order) //checks if orderproduct exists, then moves the ones that exist into new array
        {
            OrderProductArr orderProductArr = new OrderProductArr();
            OrderProduct orderProduct;
            for (int i = 0; i < this.Count; i++)
            {
                orderProduct = (this[i] as OrderProduct);
                if (orderProduct.Order.Id == order.Id)
                    orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }
        public OrderProductArr Filter(Product curProduct) //checks if orderproduct exists, then moves the ones that exist into new array
        {
            OrderProductArr orderProductArr = new OrderProductArr();
            OrderProduct orderProduct;
            for (int i = 0; i < this.Count; i++)
            {
                orderProduct = (this[i] as OrderProduct);
                if (orderProduct.Product.Id == curProduct.Id)
                    orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }
        

        public bool Insert()
        {

            // מוסיפה את אוסף המוצרים להזמנה למסד הנתונים

            OrderProduct orderProduct = null;
            for (int i = 0; i < this.Count; i++)
            {
                orderProduct = (this[i] as OrderProduct);
                if (!orderProduct.Insert())
                    return false;
            }
            return true;
        }

        public bool Delete()
        {

            //מוחקת את אוסף המוצרים להזמנה ממסד הנתונים

            for (int i = 0; i < this.Count; i++)
                (this[i] as OrderProduct).Delete();
            return true;
        }

        public ProductArr GetProductArr()
        {

            //מחזירה את אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            ProductArr productArr = new ProductArr();
            for (int i = 0; i < this.Count; i++)
                productArr.Add((this[i] as OrderProduct).Product);
            return productArr;
        }
    }
}
