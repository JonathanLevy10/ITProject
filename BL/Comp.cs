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
    class Comp
    {
        #region Members
        private int m_Id;
        private Category m_Category;
        private DateTime m_Date;
        private string m_Name;
        
        public int Id { get => m_Id; set => m_Id = value; }
        public Category Category { get => m_Category; set => m_Category = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        #endregion

        public Comp() { }
        public Comp(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            m_Category = new Category(dataRow.GetParentRow("CompCategory"));
            m_Name = dataRow["Name"].ToString();
            m_Date = (DateTime)dataRow["Date"];
        }
        public bool Insert()
        {
            return Comp_Dal.Insert(m_Id, m_Category.Id, m_Date, m_Name);
        }
        public bool Update()
        {
            return Comp_Dal.Update(m_Id, m_Category.Id, m_Date, m_Name);
        }
        public bool Delete()
        {
            return Comp_Dal.Delete(m_Id);
        }
        public override string ToString()
        { return $"{m_Category}{m_Date.ToShortDateString()}"; }

    }
}
