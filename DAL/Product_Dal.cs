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
        public static bool Insert(string name)
        {
            string sql = "INSERT INTO Table_Product"
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
            dataTable = dataset.Tables["Table_Product"];

            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_Product"))
            {
                Dal.FillDataSet(dataSet, "Table_Product", "[Name]");

                DataRelation dataRelation = null; //הגדרת משתנה קשר הגומלין

                Level_Dal.FillDataSet(dataSet);
                dataRelation = new DataRelation(
                    "ProductLevel"
                    , dataSet.Tables["Table_Level"].Columns["Id"]//עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                    , dataSet.Tables["Table_Product"].Columns["Level"]);////עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
                dataSet.Relations.Add(dataRelation);
                
                Category_Dal.FillDataSet(dataSet);
                dataRelation = new DataRelation(
                    "ProductCategory"
                    , dataSet.Tables["Table_Category"].Columns["Id"]//עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                    , dataSet.Tables["Table_Product"].Columns["Category"]);////עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
                dataSet.Relations.Add(dataRelation);
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

            string str = "DELETE FROM Table_Product WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}

