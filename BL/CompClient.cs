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
    class CompClient
    {
        #region Members
        private int m_Id;
        private Comp m_Comp;
        private Client m_Client;
        public int Id { get => m_Id; set => m_Id = value; }
        public Comp Comp { get => m_Comp; set => m_Comp = value; }
        public Client Client { get => m_Client; set => m_Client = value; }
        #endregion
        public CompClient() { }
        public CompClient(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            m_Comp = new Comp(dataRow.GetParentRow("CompClientComp"));
            m_Client = new Client(dataRow.GetParentRow("CompClientClient"));
        }
        public bool Insert()
        {
            return CompClient_Dal.Insert(m_Comp.Id, m_Client.id);
        }
        public override string ToString()
        { return $"{m_Comp} {m_Client}"; }
        public bool Update()
        {
            return CompClient_Dal.Update(m_Id, m_Comp.Id, m_Client.id);
        }
        public bool Delete()
        {
            return CompClient_Dal.Delete(m_Id);
        }

    }
}
