using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSignup.DAL;

namespace ClientSignup.BL
{
    public class Client
    {
        private string m_FirstName; // Client's first name
        private string m_LastName; // Client's last name
        private string m_Email; // Client's email address
        private string m_Pwd; // Client's password
        private string m_Gender; // Client's gender

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public string Pwd { get => m_Pwd; set => m_Pwd = value; }
        public string Gender { get => m_Gender; set => m_Gender = value; }

        public void Insert()
        {
            Client_Dal.Insert(m_FirstName, m_LastName, m_Email, m_Pwd, m_Gender);
        }
    }
}
