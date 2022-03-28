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
    public class Product
    {
        #region Members
        private int m_Id;
        private string m_Name;
        private Level m_Level;
        private Category m_Category;
        private int m_Count;


        public int Id { get => m_Id; set => m_Id = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public Level Level { get => m_Level; set => m_Level = value; }      
        public Category Category { get => m_Category; set => m_Category = value; }
        public int Count { get => m_Count; set => m_Count = value; }
        #endregion
        public Product() { }
        public Product(DataRow dataRow)
        {
            m_Id = (int)dataRow["Id"];
            m_Name = dataRow["Name"].ToString();
            m_Level = new Level(dataRow.GetParentRow("ProductLevel"));
            m_Category = new Category(dataRow.GetParentRow("ProductCategory"));
            m_Count = (int)dataRow["Count"];

        }
        public bool Insert()
        {
            return Product_Dal.Insert(m_Name, m_Category.Id, m_Level.Id, m_Count); // Sends product information to DAL layer for insertion to database
        }
        public bool Update()
        {

            return Product_Dal.Update(m_Id, m_Name, m_Level.Id, m_Category.Id, m_Count);
        }
        public bool Delete()
        {
            return Product_Dal.Delete(m_Id);
        }
        public override string ToString()
        {
            if (m_Count > 0)
                return $"{m_Name} [{m_Category.Name}] ({m_Count} Open places)";
            else
                return $"{m_Name} [{m_Category.Name}] (Full)";
        }
    }
}

