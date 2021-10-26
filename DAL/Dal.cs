using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

class Dal
{
    
    public static bool ExecuteSql(string sql)
    {
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = GetConnectionString();

        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = sql;

        try
        {
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return true;
        }

        catch (Exception e)
        {
            e.ToString();
        }

        return false;
    }

    public static void FillDataSet(DataSet dataSet, string tableName, string orderBy = "")
    {
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = GetConnectionString();

        SqlCommand command = new SqlCommand();
        command.Connection = connection;

        if (orderBy != "")
            command.CommandText = "SELECT * FROM " + tableName + " ORDER BY " + orderBy;
        else
            command.CommandText = "SELECT * FROM " + tableName;

        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = command;
        adapter.Fill(dataSet, tableName);
    }

    private static string GetConnectionString()
    {
        SqlConnectionStringBuilder cString = new SqlConnectionStringBuilder();

        cString.DataSource = @"(localdb)\.";
        cString.AttachDBFilename = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\DB_ClientSignup.mdf";

        return cString.ToString();
    }
}