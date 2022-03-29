using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP_GOS.DAL
{
    class Comp_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataset = new DataSet();

            FillDataSet(dataset);
            dataTable = dataset.Tables["Table_Comps"];

            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_Comps"))
            {
                Dal.FillDataSet(dataSet, "Table_Comps");
                Category_Dal.FillDataSet(dataSet);
                DataRelation dataRelation = null;
                dataRelation = new DataRelation(
                    "CompCategory"
                    , dataSet.Tables["Table_Category"].Columns["Id"]//עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                    , dataSet.Tables["Table_Comps"].Columns["Category"]);////עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
                dataSet.Relations.Add(dataRelation);
            }
        }
        public static bool Update(int id, int category, DateTime date, string name)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Comp SET"
            + $"[Category] = N'{category}'"
            + $"[Date] = N'{date:yyyy-MM-dd}'"
            + $"[Name] = N'{name}'"
            + $"WHERE [Id] = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה
            return Dal.ExecuteSql(str);
        }
        public static bool Insert(int id, int category, DateTime date, string name)
        { // Adds location directly to database via SQL
            string sql = "INSERT INTO Table_Comps"
            + "("
            + "[Category]"
            + ")"
            + " VALUES "
            + "("
            + $"'{category}'"
            + ")"
            + "("
            + "[Date]"
            + ")"
            + " VALUES "
            + "("
            + $"'{date:yyyy-MM-dd}'"
            + ")"
            + "("
            + "[Notes]"
            + ")"
            + " VALUES "
            + "("
            + "[Name]"
            + ")"
            + " VALUES "
            + "("
            + $"'{name}'"
            + ")";

            return Dal.ExecuteSql(sql);
        }
        public static bool Delete(int id)
        {
            //מוחקת את הפריט ממסד הנתונים
            return Dal.ExecuteSql($"DELETE FROM Table_CompClient WHERE ID = {id}");
        }
    }
}
