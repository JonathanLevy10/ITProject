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
    public class Category
    {
        #region Members
        private int m_Id;
        private string m_Name;


        public int Id { get => m_Id; set => m_Id = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        #endregion


        public Category() { }
        public Category(DataRow dataRow)
        {
            m_Id = (int)dataRow["Id"];
            m_Name = dataRow["Name"].ToString();

        }
        public bool Insert()
        {
            return Category_Dal.Insert(m_Name);  //Sends Category information to DAL layer

        }
        public bool Update()
        {
            return Category_Dal.Update(m_Id, m_Name);
        }
        public bool Delete()
        {
            return Category_Dal.Delete(m_Id);
        }
        public override string ToString()
        { return $"{m_Name}"; }
    }
}
