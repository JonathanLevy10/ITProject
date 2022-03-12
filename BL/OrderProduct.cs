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
    class OrderProduct
    {
        #region Members
        private int m_Id;
        private Order m_Order; 
        private Product m_Product; 
        public int Id { get => m_Id; set => m_Id = value; }
        public Order Order { get => m_Order; set => m_Order = value; }
        public Product Product { get => m_Product; set => m_Product = value; }
        #endregion
        public OrderProduct() { }
        public OrderProduct(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            m_Order = new Order(dataRow.GetParentRow("OrderProductOrder"));
            m_Product = new Product(dataRow.GetParentRow("OrderProductProduct"));
        }
        public bool Insert()
        {
            return OrderProduct_Dal.Insert(m_Order.Id, m_Product.Id);
        }
        public override string ToString()
        { return $"{m_Order} {m_Product}"; }
        public bool Update()
        {
            return OrderProduct_Dal.Update(m_Id, m_Order.Id, m_Product.Id);
        }
        public bool Delete()
        {
            return OrderProduct_Dal.Delete(m_Id);
        }

    }

}

