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
    public class Client
    {
        #region Members
        private string m_FirstName; // Client's first name
        private string m_LastName; // Client's last name
        private string m_Email; // Client's email address
        private string m_Pwd; // Client's password
        private string m_Gender; // Client's gender
        private bool m_IsPro; //If client is a professional, the value will be true
        private int m_id; //clients individual and unique id used for identifying clients
        private Location m_Location;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public string Pwd { get => m_Pwd; set => m_Pwd = value; }
        public string Gender { get => m_Gender; set => m_Gender = value; }
        public Location Location { get => m_Location; set => m_Location = value; }
        public bool IsPro { get => m_IsPro; set => m_IsPro = value; }
        public int id { get => m_id; set => m_id = value; }
        
        public string FullName { get => $"{m_FirstName} {m_LastName}"; }
        #endregion


        // Sends client information to DAL layer for insertion to database
        public bool Insert()
        {
            return Client_Dal.Insert(m_FirstName, m_LastName, m_Email, m_Pwd, m_Gender, m_Location.Id, m_IsPro);
        }
        public Client() { }
        public Client(DataRow dataRow)
        {
            this.m_id = (int)dataRow["ID"];
            m_FirstName = dataRow["FirstName"].ToString();
            m_LastName = dataRow["LastName"].ToString();
            m_Email = dataRow["Email"].ToString();
            m_Pwd = dataRow["Pwd"].ToString();
            m_Gender = dataRow["Gender"].ToString();
            m_Location = new Location(dataRow.GetParentRow("ClientLocation"));
            m_IsPro = (bool)dataRow["IsPro"];
        }
        public override string ToString()
        { return $"{m_LastName} {m_FirstName}"; }
        public bool Update()
        {
            
            return Client_Dal.Update(m_id, m_FirstName, m_LastName, m_Email, m_Pwd, m_Gender, m_Location.Id, m_IsPro);
        }
        public bool Delete()
        {
            return Client_Dal.Delete(m_id);
        }
    }





}

