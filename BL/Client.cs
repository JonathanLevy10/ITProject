using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.BL
{
    public class Client
    {
        private string m_FirstName;
        private string m_LastName;
        private string m_Email;
        private string m_Pwd;
        private string m_Gender;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public string Pwd { get => m_Pwd; set => m_Pwd = value; }
        public string Gender { get => m_Gender; set => m_Gender = value; }
    }
}
