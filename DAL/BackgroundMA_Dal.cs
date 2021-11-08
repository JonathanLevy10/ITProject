using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.DAL
{
    class BackgroundMA_Dal
    {
        // Adds client directly to database via SQL
        public static bool Insert(string BackgroundMA)
        {
            string sql = "INSERT INTO Table_BackgroundMA"
            + "("
            + "[BackgroundMA]"
            + ")"
            + " VALUES "
            + "("
            + $"'{BackgroundMA}'"
            + ")";

            return Dal.ExecuteSql(sql);
        }
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataset = new DataSet();

            FillDataSet(dataset);
            dataTable = dataset.Tables["Table_BackgroundMA"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_BackgroundMA"))
            {
                Dal.FillDataSet(dataSet, "Table_BackgroundMA", "[Name]");
            }
            
        }



        public static bool Update(int id, string backgroundMA)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_BackgroundMA SET"
            + $",[BackgroundMA] = N'{backgroundMA}'"
            + $"WHERE [Id] = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            string str = $"DELETE FROM Table_BackgroundMA WHERE ID = {id}";

            return Dal.ExecuteSql(str);
        }
    }
}
