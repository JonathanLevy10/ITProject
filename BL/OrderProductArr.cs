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
    class OrderProductArr : ArrayList
    {
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
        public ProductArr GetProductArr()
        {

            //מחזירה את אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            ProductArr productArr = new ProductArr();
            for (int i = 0; i < this.Count; i++)
                productArr.Add((this[i] as OrderProduct).Product);
            return productArr;
        }
        public bool DoesExist(Product curProduct)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as OrderProduct).Product.Id == curProduct.Id)
                    return true;

            return false;
        }
        public ProductArr FilterByMostSales()
        {
            int sold = 0;
            Product mostSold = new Product();
            ProductArr productArr = new ProductArr();
            productArr.Fill();
            int count = productArr.Count;
            ProductArr productArr_New = new ProductArr();
            for (int j = 0; j < count; j++) //scans the entire database (database.Items.Count) times
            {
                Product product = (productArr[j] as Product); //saves current productArr index as product
                mostSold = product;
                for (int i = 0; i < this.Count; i++) //scans the entire database
                {
                    OrderProduct orderProduct = (this[i] as OrderProduct); //saves current orderProduct index as orderProduct
                    if (orderProduct.Product.Id == product.Id) //if the current productArr index is in this orderProduct entry
                        sold += 1; //add to amount of sales the amount of the product's count
                }
                for (int i = sold; i > 0; i--) //(amount of sales) times
                {
                    productArr_New.Add(mostSold); //adds the product which his sales have been calculated into the new productArr
                    //there will be a method which translates this to sales number in FillListView()
                }
                sold = 0; //removes the product which his sales have been calculated from the productArr and move on to the next product to check
            }
            return productArr_New; //return the new productArr with the products pasted inside * the amount of sales they've had
        }
    }
}
