﻿using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignup.DAL
{
    class Product_Dal
    {
        // Adds client directly to database via SQL
        public static bool Insert(string name)
        {
            string sql = "INSERT INTO Table_Location"
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
            dataTable = dataset.Tables["Table_Location"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_Location"))
            {
                Dal.FillDataSet(dataSet, "Table_Location", "[Name]");
            }


        }



        public static bool Update(int id, string name, int level, int category)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Products SET"
            + $"[Name] = N'{name}'"
            + $"[Level] = N'{level}'"
            + $"[Category] = N'{category}'"
            + $"WHERE [Id] = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הישוב ממסד הנתונים

            string str = "DELETE FROM Table_Location WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}

