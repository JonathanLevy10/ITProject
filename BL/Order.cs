using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.BL
{
    class Order
    {
        #region Members
        private int m_Id;
        private string m_Client;
        private DateTime m_Date;
        private string m_Notes;


        public int Id { get => m_Id; set => m_Id = value; }
        public string Client { get => m_Client; set => m_Client = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }
        public string Notes { get => m_Notes; set => m_Notes = value; }
        #endregion
    }
}
