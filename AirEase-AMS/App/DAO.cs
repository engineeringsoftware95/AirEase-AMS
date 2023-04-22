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
    private bool isConnected = false;
    /// <summary>
    /// This is the constructor for the database access object. It will initialize a connection to the database.
    /// </summary>
    public DatabaseAccessObject()
    {
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

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
            isConnected = true; //TODO: statement or branch uncovered

        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
            isConnected = false;
            
        }
        catch(System.InvalidOperationException e) //TODO: statement or branch uncovered
        {
            Console.WriteLine(e.ToString());
            isConnected = false;
        }
    }

    /// <summary>
    /// Standard destructor for DAO. Closes the database connection.
    /// </summary>
    ~DatabaseAccessObject()
    {
        if (connection != null) { connection.Close(); }
    }
    public bool IsConnected { get { return isConnected; } }

    /// <summary>
    /// A general function for database SELECTS. Expects to get some return value, or it returns null.
    /// </summary>
    /// <param name="sqlQuery">The query being passed to the database (WARNING: query needs sanitized before getting here!)</param>
    /// <returns>A data table object, populated with the results of the input search query. Can be null.</returns>
    public DataTable Retrieve(string sqlQuery)
    {
        if(sqlQuery== "") return new DataTable();
        //No connection established - return error
        if (connection == null)
        { //TODO: statement or branch uncovered
            Console.WriteLine("Connection is null. Abort."); 
            return new DataTable();
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
                    { //TODO: statement or branch uncovered
                        return new DataTable();
                    }
                    else
                    {
                        //The reader is intrinsically intertwined with the database - when it goes out of scope, it loses connection.
                        //For that reason, it can not be returned here. The DataTable makes for a fine substitute.

                        //Load our data table for return.  
                        System.Data.DataTable dt = new System.Data.DataTable();//TODO: statement or branch uncovered
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }
        catch (SqlException e)
        {//TODO: statement or branch uncovered
            //Print exception info
            Console.WriteLine(e.ToString());
        }
        catch (System.InvalidOperationException e)
        {
            Console.WriteLine(e.ToString());
        }
        //Looks like an exception occurred - return null.
        return new DataTable();
    }

    /// <summary>
    ///  A general function for database edits. Returns the number of rows altered.
    /// </summary>
    /// <param name="sqlQuery">The query being passed to the database</param>
    /// <returns>The number of rows altered by the input query.</returns>
    public int Update(string sqlQuery)
    {
        if (sqlQuery == "") return 0;
        //No connection established - return error
        if (connection == null)
        {//TODO: statement or branch uncovered
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
                {//TODO: statement or branch uncovered
                    //Return the number of rows affected by our input query.
                    return reader.RecordsAffected;
                }
            }
        }
        catch (SqlException e)
        {//TODO: statement or branch uncovered
            //Print exception info
            Console.WriteLine(e.ToString());
        }//TODO: statement or branch uncovered
        //Looks like an exception occurred - return error code.
        return -1;//TODO: statement or branch uncovered
    }

    /// <summary>
    /// DEBUG: Prints the attributes of a data table object.
    /// </summary>
    /// <param name="dt">The data table being printed.</param>
    public void PrintDataTable(DataTable? dt)
    {
        if (dt != null)
        {//TODO: statement or branch uncovered

            foreach (DataRow row in dt.Rows)
            {//TODO: statement or branch uncovered
                foreach (DataColumn col in dt.Columns)
                {
                    if (col.DataType.Equals(typeof(DateTime)))//TODO: statement or branch uncovered
                        Console.Write("{0,-14:d}", row[col]);
                    else if (col.DataType.Equals(typeof(Decimal)))//TODO: statement or branch uncovered
                        Console.Write("{0,-14:C}", row[col]);
                    else//TODO: statement or branch uncovered
                        Console.Write("{0,-14}", row[col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Sanitizes a user input string.
    /// </summary>
    /// <param name="input">The input string to be sanitized.</param>
    /// <returns>Returns the sanitized string.</returns>
    public static string SanitizeString(string input)
    {//TODO: statement or branch uncovered
        return input.Replace("'", "''");
    }
}

