using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CallDataLayer
{
   public class TelcoManager
    {
         
     public List<Telco> GetAllTelcos()
        {
            // get an instance of databasemanager use it to get a database connection

            DatabaseManager db = new DatabaseManager();
            OleDbConnection dbConn = db.GetOpenedConnection();

            // 2 select query and command
            string query = "SELECT * FROM tblTelco";
            OleDbCommand dbCmd = new OleDbCommand(query, dbConn);

            // 3 create list objects to store results of query
            List<Telco> list = new List<Telco>();

            // 4 create a reader object using dbcmd to iterate rows
            OleDbDataReader reader = dbCmd.ExecuteReader();

            // 5 use a while loop and the reader object to process rows
            while (reader.Read())
            {
                Telco record = new Telco();

                // 7 copy data from the reader into the blank object
                // object.property = type reader databasefield
                record.ID = (int)reader["TelcoID"];
                record.TelcoName = (string)reader["TelcoName"];

                // 8 add the filled object to the list
                list.Add(record);

            } // end of while loop

            // close the reder 
            reader.Close();
            dbConn.Close();

            // retur list of artists
            return list;




        }
    }
}

