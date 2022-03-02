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
    public class Product
    {
        #region Members
        private int m_id;
        private string m_Name;
        private Level m_Level;
        private Category m_Category;

        public int Id { get => m_id; set => m_id = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public Level Level { get => m_Level; set => m_Level = value; }      
        public Category Category { get => m_Category; set => m_Category = value; }
        #endregion

        public Product() { }
        public Product(DataRow dataRow)
        {
            m_id = (int)dataRow["Id"];
            m_Name = dataRow["Name"].ToString();
            m_Level = new Level(dataRow.GetParentRow("ProductLevel"));
            m_Category = new Category(dataRow.GetParentRow("ProductCategory"));

        }


        public bool Insert()
        {
            return Product_Dal.Insert(m_Name); // Sends product information to DAL layer for insertion to database
        }
        public bool Update()
        {

            return Product_Dal.Update(m_id, m_Name, m_Level.Id, m_Category.Id);
        }
        public bool Delete()
        {
            return Product_Dal.Delete(m_id);
        }
        public override string ToString()
        { return $"{m_Level}"; }
        public void Remove(Product product)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this.[i] as Product).Id == product.Id)
                    this.RemoveAt(i); return;
            }
        }

    }
}

