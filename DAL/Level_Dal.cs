using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.DAL
{
    class Level_Dal
    {
        ///OK
        public static bool Insert(string name)
        {
            string sql = "INSERT INTO Table_Level"
            + "("
            + "[Name]"
            + ")"
            + " VALUES "
            + "("
            + $"'{name}'"
            + ")";

            return Dal.ExecuteSql(sql);
        }
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataset = new DataSet();

            FillDataSet(dataset);
            dataTable = dataset.Tables["Table_Level"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_Level"))
            {
                Dal.FillDataSet(dataSet, "Table_Level", "[Name]");
            }
        }



        public static bool Update(int id, string name)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Level SET"
            + $"[Name] = N'{name}'"
            + $"WHERE [Id] = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הישוב ממסד הנתונים

            string str = "DELETE FROM Table_Level WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}
