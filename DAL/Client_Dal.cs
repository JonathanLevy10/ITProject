using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.DAL
{
    class Client_Dal
    {
        public static void Insert(string firstName, string lastName, string email, string pwd, string gender)
        {
            string sql = $"INSERT INTO Table_Client ([FirstName,[LastName],[Email],[Pwd],[Gender] VALUES ('{firstName}', '{lastName}', '{email}', '{pwd}', '{gender}'";
            Dal.ExecuteSql(sql);
        }
    }
}
