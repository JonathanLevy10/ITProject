using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP_GOS.DAL
{
    class Order_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataset = new DataSet();

            FillDataSet(dataset);
            dataTable = dataset.Tables["Table_Order"];

            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_Order"))
            {
                Dal.FillDataSet(dataSet, "Table_Order");
                Client_Dal.FillDataSet(dataSet);
                DataRelation dataRelation = null;
                dataRelation = new DataRelation(
                    "OrderClient"
                    , dataSet.Tables["Table_Client"].Columns["Id"]//עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                    , dataSet.Tables["Table_Order"].Columns["Client"]);////עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
                dataSet.Relations.Add(dataRelation);
            }
        }
        public static bool Update(int id, int client, DateTime date, string notes)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Order SET"
            + $" [Client] = {client}"
            + $",[Date] = N'{date:yyyy-MM-dd}'"
            + $",[Note] = N'{notes}'"
            + $" WHERE [Id] = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה
            return Dal.ExecuteSql(str);
        }
        public static bool Insert(int client, DateTime date, string notes)
        { // Adds location directly to database via SQL
            string sql = "INSERT INTO Table_Order"
            + "("
            + "[Client],[Date],[Note]"
            + ")"
            + " VALUES "
            + "("
            + $"'{client}','{date}','{notes}'"
            + ")";

            return Dal.ExecuteSql(sql);
        }
        public static bool Delete(int id)
        {
            //מוחקת את הפריט ממסד הנתונים
            return Dal.ExecuteSql($"DELETE FROM Table_OrderProduct WHERE ID = {id}");
        }
    }
}
