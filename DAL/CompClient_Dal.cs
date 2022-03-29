using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP_GOS.DAL
{
    class CompClient_Dal
    {
        public static bool Insert(int Comp, int Client)
        {
            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL
            string str = "INSERT INTO Table_CompClient"
            + "("
            + "[Comp], [Client]"
            + ")"
            + " VALUES "
            + "("
            + $"{Comp}, {Client}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_CompClient"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_CompClient"))
            {
                Dal.FillDataSet(dataSet, "Table_CompClient");

                Client_Dal.FillDataSet(dataSet);
                DataRelation dataRelation = null;
                dataRelation = new DataRelation("CompClientClient"
                //המפתח הראשי של טבלת האב
                , dataSet.Tables["Table_Client"].Columns["ID"]
                //עמודת הקשר בטבלת הבן
                , dataSet.Tables["Table_CompClient"].Columns["Client"]);
                //הוספת קשר הגומלין לאוסף הטבלאות
                dataSet.Relations.Add(dataRelation);

                Comp_Dal.FillDataSet(dataSet);
                dataRelation = new DataRelation("CompClientComp"
                //המפתח הראשי של טבלת האב
                , dataSet.Tables["Table_Comps"].Columns["ID"]
                //עמודת הקשר בטבלת הבן
                , dataSet.Tables["Table_CompClient"].Columns["Comp"]);
                //הוספת קשר הגומלין לאוסף הטבלאות
                dataSet.Relations.Add(dataRelation);
            }
        }
        public static bool Update(int Id, int Comp, int Client)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_CompClient SET"

            + $",[Comp] = {Comp}"
            + $",[Client] = {Client}"
            + $" WHERE [Id] = {Id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {
            //מוחקת את הפריט ממסד הנתונים
            return Dal.ExecuteSql($"DELETE FROM Table_CompClient WHERE ID = {id}");
        }
    }
}
