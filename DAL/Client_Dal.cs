using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.DAL
{
    class Client_Dal
    {
        // Adds client directly to database via SQL execution
        public static bool Insert(string firstName, string lastName, string email, string pwd, string gender)
        {
            string sql = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[Email],[Pwd],[Gender]"
            + ")"
            + " VALUES "
            + "("
            + $"'{firstName}','{lastName}','{email}','{pwd}','{gender}'"
            + ")";

            return Dal.ExecuteSql(sql);
        }
    }
}
