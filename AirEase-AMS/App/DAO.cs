using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
public class DatabaseAccessObject
{
    SqlConnection? connection = null;
    /// <summary>
    /// This is the constructor for the database access object. It will initialize a connection to the database.
    /// </summary>
    public DatabaseAccessObject()
    {
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            //builder.DataSource = "THE";
            builder["Server"] = "localhost";
            builder.UserID = "TheBackdoor";
            builder.Password = "Password123";
            builder.InitialCatalog = "AirEase";
            builder.Encrypt = false;
            builder["Trusted_Connection"] = true;
            connection = new SqlConnection(builder.ConnectionString);
            connection.Open();

        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    ~DatabaseAccessObject()
    {
        if (connection != null) { connection.Close(); }
    }

    public DataTable? Retrieve(string sqlQuery)
    {
        if (connection == null)
        {
            Console.WriteLine("Connection is null. Abort.");
            return null;
        }
        try
        {
            String sql = sqlQuery;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        return null;
                    }
                    else
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }

        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }
        return null;
    }

    public int Update(string sqlQuery)
    {
        if (connection == null)
        {
            Console.WriteLine("Connection is null. Abort.");
            return -1;
        }
        try
        {

            String sql = sqlQuery;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    return reader.RecordsAffected;
                }
            }
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }
        return -1;
    }


    public void PrintDataTable(DataTable? dt)
    {
        if (dt != null)
        {

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    if (col.DataType.Equals(typeof(DateTime)))
                        Console.Write("{0,-14:d}", row[col]);
                    else if (col.DataType.Equals(typeof(Decimal)))
                        Console.Write("{0,-14:C}", row[col]);
                    else
                        Console.Write("{0,-14}", row[col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


    }
}

