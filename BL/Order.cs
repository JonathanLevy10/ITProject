using ClientSignup.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.BL
{
    class Order
    {
        #region Members
        private int m_Id;
        private Client m_Client;
        private DateTime m_Date;
        private string m_Notes;


        public int Id { get => m_Id; set => m_Id = value; }
        public Client Client { get => m_Client; set => m_Client = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }
        public string Notes { get => m_Notes; set => m_Notes = value; }
        #endregion

        public Order() { }
        public Order(DataRow dataRow)
        {
            m_Id = (int)dataRow["Id"];
            m_Client = new Client(dataRow.GetParentRow("OrderClient"));
            m_Date = (DateTime)dataRow["Date"];
            m_Notes = dataRow["Notes"].ToString();
        }

        public bool Insert()
        {
            return Order_Dal.Insert(m_Client.id, m_Date, m_Notes);
        }
        public bool Update()
        {
            return Order_Dal.Update(m_Id, m_Client.id, m_Date, m_Notes);
        }
        public bool Delete()
        {
            return Order_Dal.Delete(m_Id);
        }

        public override string ToString()
        { return $"{m_Client}{m_Date.ToShortDateString()}"; }
    }
}
