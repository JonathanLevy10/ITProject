using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.DAL
{
    class Client_Dal
    {
        // Adds client directly to database via SQL
        public static bool Insert(string firstName, string lastName, string email, string pwd, string gender, string BackgroundMA, bool isPro)
        {
            string sql = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[Email],[Pwd],[Gender], [BackgroundMA], [isPro]"
            + ")"
            + " VALUES "
            + "("
            + $"'{firstName}','{lastName}','{email}','{pwd}','{gender}', '{BackgroundMA}', '{isPro}'"
            + ")";

            return Dal.ExecuteSql(sql);
        }
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataset = new DataSet();

            FillDataSet(dataset);
            dataTable = dataset.Tables["Table_Client"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            Dal.FillDataSet(dataSet, "Table_Client", "[LastName], [FirstName]");
        }



        public static bool Update(int id, string firstName, string lastName, string email, string pwd, string gender, string backgroundMA, bool isPro)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $" [FirstName] = N'{firstName}'"
            + $",[LastName] = N'{lastName}'"
            + $",[Email] = N'{email}'"
            + $",[Pwd] = N'{pwd}'"
            + $",[Gender] = N'{gender}'"
            + $",[BackgroundMA] = N'{backgroundMA}'"
            + $",[isPro] = {isPro}"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = $"DELETE FROM Table_Client WHERE ID = {id}";

            return Dal.ExecuteSql(str);
        }
    }
}
