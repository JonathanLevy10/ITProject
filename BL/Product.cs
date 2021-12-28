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
    class Product
    {
        private int m_id;
        private string m_Name;
        private string m_Level;
        private string m_Category;


        public int Id { get => m_id; set => m_id = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public string Level { get => m_Level; set => m_Level = value; }      
        public string Category { get => m_Category; set => m_Category = value; }


        // Sends client information to DAL layer for insertion to database
        public bool Insert()
        {
            return Product_Dal.Insert(m_Name);
        }

        public Product() { }

        public Product(DataRow dataRow)
        {
            this.m_id = (int)dataRow["ID"];
            m_Level = dataRow["Name"].ToString();

        }
        public override string ToString()
        { return $"{m_Level}"; }


        public bool Update()
        {

            return Product_Dal.Update(m_id, m_Name, m_Level, m_Category);
        }


        public bool Delete()
        {
            return Product_Dal.Delete(m_id);
        }


    }
}

