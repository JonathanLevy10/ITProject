using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.DAL
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
                Dal.FillDataSet(dataSet, "Table_Order", "[Client]");
            }
        }
        public static bool Update(int id, string client, DateTime date, string notes)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Order SET"
            + $"[Client] = N'{client}'"
            + $"[Date] = N'{date:yyyy-MM-dd}'"
            + $"[Notes] = N'{notes}'"
            + $"WHERE [Id] = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה
            return Dal.ExecuteSql(str);
        }
        public static bool Insert(string client, DateTime date, string notes)
        { // Adds location directly to database via SQL
            string sql = "INSERT INTO Table_Location"
            + "("
            + "[Client]"
            + ")"
            + " VALUES "
            + "("
            + $"'{client}'"
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
            + $"'{notes}'"
            + ")";

            return Dal.ExecuteSql(sql);
        }
        public static bool Delete(int id)
        {

            //מוחקת את הישוב ממסד הנתונים

            string str = "DELETE FROM Table_Order WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

    }
}
