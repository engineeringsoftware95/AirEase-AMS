﻿using System;
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

            //This is the name of the SQL Server - don't ask why
            builder.DataSource = "THE";

            //We need to tell the connection object - WE WANT TO CONNECT USING TCP!
            //Otherwise, we would need to be a trusted_connection, and talk via pipes.
            //This works fine if we're only ever using localhost on your local windows device - not optimal!!
            builder["Server"] = "tcp:localhost";

            //We've spent millions on achieving the best security money can buy
            builder.UserID = "SecretEntrance";
            builder.Password = "123456";

            //Our Database catalog
            builder.InitialCatalog = "AirEase";

            //We could encrypt it - but then we would need to implement some certification method... but... lets call that a stretch goal, kay?
            builder.Encrypt = false;

            //Establish a connection (possible point of failure)
            connection = new SqlConnection(builder.ConnectionString);

            //Once the connection is open, we have finished our job here!!
            connection.Open();

        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    /// <summary>
    /// Standard destructor for DAO. Closes the database connection.
    /// </summary>
    ~DatabaseAccessObject()
    {
        if (connection != null) { connection.Close(); }
    }


    /// <summary>
    /// A general function for database SELECTS. Expects to get some return value, or it returns null.
    /// </summary>
    /// <param name="sqlQuery">The query being passed to the database (WARNING: query needs sanitized before getting here!)</param>
    /// <returns>A data table object, populated with the results of the input search query. Can be null.</returns>
    public DataTable? Retrieve(string sqlQuery)
    {
        //No connection established - return error
        if (connection == null)
        {
            Console.WriteLine("Connection is null. Abort.");
            return null;
        }
        try
        {
            String sql = sqlQuery;

            //Establish our command and reader - they will be automatically disposed of when out of scope.
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //No return data - return null object
                    if (!reader.HasRows)
                    {
                        return null;
                    }
                    else
                    {
                        //The reader is intrinsically intertwined with the database - when it goes out of scope, it loses connection.
                        //For that reason, it can not be returned here. The DataTable makes for a fine substitute.

                        //Load our data table for return.  
                        System.Data.DataTable dt = new System.Data.DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }

        }
        catch (SqlException e)
        {
            //Print exception info
            Console.WriteLine(e.ToString());
        }
        //Looks like an exception occurred - return null.
        return null;
    }

    /// <summary>
    ///  A general function for database edits. Returns the number of rows altered.
    /// </summary>
    /// <param name="sqlQuery">The query being passed to the database (WARNING: query needs sanitized before getting here!)</param>
    /// <returns>The number of rows altered by the input query.</returns>
    public int Update(string sqlQuery)
    {
        //No connection established - return error
        if (connection == null)
        {
            Console.WriteLine("Connection is null. Abort.");
            return -1;
        }
        try
        {

            String sql = sqlQuery;

            //Establish our command and reader - they will be automatically disposed of when out of scope.
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Return the number of rows affected by our input query.
                    return reader.RecordsAffected;
                }
            }
        }
        catch (SqlException e)
        {
            //Print exception info
            Console.WriteLine(e.ToString());
        }
        //Looks like an exception occurred - return error code.
        return -1;
    }

    /// <summary>
    /// DEBUG: Prints the attributes of a data table object.
    /// </summary>
    /// <param name="dt">The data table being printed.</param>
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

