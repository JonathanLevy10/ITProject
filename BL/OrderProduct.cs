using ClientSignup.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.BL
{
    class OrderProduct
    {

        private int m_Id;
        private Order m_Order; 
        private Product m_Product; 
        public int Id { get => m_Id; set => m_Id = value; }
        public Order Order { get => m_Order; set => m_Order = value; }
        public Product Product { get => m_Product; set => m_Product = value; }
      

        // Sends order information to DAL layer for insertion to database
        public bool Insert()
        {
            return OrderProduct_Dal.Insert(m_Order.Id, m_Product.Id);
        }

        public OrderProduct() { }

        public OrderProduct(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            m_Order = dataRow["Order"].ToString();
            m_Product = dataRow["Product"].ToString();
        }
        public override string ToString()
        { return $"{m_Order} {m_Product}"; }


        public bool Update()
        {

            return Client_Dal.Update(m_id, m_Order, m_Product);
        }


        public bool Delete()
        {
            return Client_Dal.Delete(m_id);
        }
    }

}
}
