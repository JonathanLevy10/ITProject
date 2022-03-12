using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ClientSignup.DAL
{
    class OrderProduct_Dal
    {
        public static bool Insert(int Order, int Product)
        {
            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL
            string str = "INSERT INTO Table_OrderProduct"
            + "("
            + "[Order], [Product]"
            + ")"
            + " VALUES "
            + "("
            + $"{Order}, {Product}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_OrderProduct"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_OrderProduct"))
            {
                Dal.FillDataSet(dataSet, "Table_OrderProduct");

                Product_Dal.FillDataSet(dataSet);
                DataRelation dataRelation = null;
                dataRelation = new DataRelation("OrderProductProduct"
                //המפתח הראשי של טבלת האב
                , dataSet.Tables["Table_Product"].Columns["ID"]
                //עמודת הקשר בטבלת הבן
                , dataSet.Tables["Table_OrderProduct"].Columns["Product"]);
                //הוספת קשר הגומלין לאוסף הטבלאות
                dataSet.Relations.Add(dataRelation);

                Order_Dal.FillDataSet(dataSet);
                dataRelation = new DataRelation("OrderProductOrder"
                //המפתח הראשי של טבלת האב
                , dataSet.Tables["Table_Order"].Columns["ID"]
                //עמודת הקשר בטבלת הבן
                , dataSet.Tables["Table_OrderProduct"].Columns["Order"]);
                //הוספת קשר הגומלין לאוסף הטבלאות
                dataSet.Relations.Add(dataRelation);
            }
        }
        public static bool Update(int Id, int Order, int Product)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_OrderProduct SET"

            + $",[Order] = {Order}"
            + $",[Product] = {Product}"
            + $" WHERE [Id] = {Id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {
            //מוחקת את הפריט ממסד הנתונים
            return Dal.ExecuteSql($"DELETE FROM Table_OrderProduct WHERE ID = {id}");
        }
    }
}
