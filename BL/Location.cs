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
    public class Location
    {
        #region Members
        private string m_Name; 
        private int m_id; //Items individual and unique id used for identifying locations
        
        public string Name { get => m_Name; set => m_Name = value; } 
        public int Id { get => m_id; set => m_id = value; }
        #endregion 
   
        public Location() { }
        public Location(DataRow dataRow)
        {
            this.m_id = (int)dataRow["ID"];
            m_Name = dataRow["Name"].ToString();
           
        }
        public override string ToString()
        { return $"{m_Name}"; }
        public bool Insert()
        {
            return Location_Dal.Insert(m_Name);
        }
        public bool Update()
        {
            
            return Location_Dal.Update(m_id, m_Name);
        }   
        public bool Delete() 
        {
            return Location_Dal.Delete(m_id);
        }

    }


}

