using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP_GOS.DAL
{
    class Client_Dal
    {
        public static bool Insert(string firstName, string lastName, string email, string pwd, string gender, int Location, bool isPro)
        {         // Adds client directly to database via SQL
            string sql = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[Email],[Pwd],[Gender], [Location], [isPro], [IdLocation]"
            + ")"
            + " VALUES "
            + "("
            + $"'{firstName}','{lastName}','{email}','{pwd}','{gender}', '{Location}', '{isPro}'"
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
            DataRelation dataRelation = null; //הגדרת משתנה קשר הגומלין
            
            Location_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(
                "ClientLocation"
                , dataSet.Tables["Table_Location"].Columns["ID"]//עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                , dataSet.Tables["Table_Client"].Columns["Location"]);////עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
            dataSet.Relations.Add(dataRelation);
        }
        public static bool Update(int id, string firstName, string lastName, string email, string pwd, string gender, int backgroundMA, bool isPro)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $" [FirstName] = N'{firstName}'"
            + $",[LastName] = N'{lastName}'"
            + $",[Email] = N'{email}'"
            + $",[Pwd] = N'{pwd}'"
            + $",[Gender] = N'{gender}'"
            + $",[Location] = N'{backgroundMA}'" //this might have to go
            + $",[isPro] = '{isPro}'"
            + $" WHERE ID = {id}";

            
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {
            string str = $"DELETE FROM Table_Client WHERE ID = {id}";

            return Dal.ExecuteSql(str);
        }

    }
}
