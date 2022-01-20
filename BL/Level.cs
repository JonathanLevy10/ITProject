using ClientSignup.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.BL
{
    public class Level
    {
        #region Members
        private int m_Id;
        private string m_Name;


        public int Id { get => m_Id; set => m_Id = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        #endregion


        public Level() { }
        public Level(DataRow dataRow)
        {
            m_Id = (int)dataRow["Id"];
            m_Name = dataRow["Name"].ToString();

        }


        //Sends Level information to DAL layer
        public bool Insert()
        {
            return Level_Dal.Insert(m_Name);
        }
        public bool Update()
        {
            return Level_Dal.Update(m_Id, m_Name);
        }
        public bool Delete()
        {
            return Level_Dal.Delete(m_Id);
        }

        public override string ToString()
        { return $"{m_Name}"; }
    }
}
