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
    public class BackgroundMA
    {
        private string m_Name; //Name of backgroundMA
        private int m_id; //Items individual and unique id used for identifying Jews
        
        public string Name { get => m_Name; set => m_Name = value; } //change this variable name to anything no errors
        public int Id { get => m_id; set => m_id = value; }
       

        // Sends client information to DAL layer for insertion to database
        public bool Insert()
        {
            return BackgroundMA_Dal.Insert(m_Name);
        }

        public BackgroundMA() { }

        public BackgroundMA(DataRow dataRow)
        {
            this.m_id = (int)dataRow["ID"];
            m_Name = dataRow["Name"].ToString();
           
        }
        public override string ToString()
        { return $"{m_Name}"; }
         

        public bool Update()
        {
            
            return BackgroundMA_Dal.Update(m_id, m_Name);
        }

        
        public bool Delete() 
        {
            return BackgroundMA_Dal.Delete(m_id);
        }
    }


}

