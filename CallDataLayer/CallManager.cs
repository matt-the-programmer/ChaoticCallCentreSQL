using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CallDataLayer
{
   public class CallManager
    {
        // GetAll
        // SaveOrUpdate



        public List<Calls> GetAllCalls()
        {
            List<Calls> list = new List<Calls>();

            DatabaseManager db = new DatabaseManager();
            OleDbConnection dbConn = db.GetOpenedConnection();

            string query = "SELECT * FROM tblCallCentre";
            OleDbCommand dbCmd = new OleDbCommand(query, dbConn);

            OleDbDataReader reader = dbCmd.ExecuteReader();

            while (reader.Read())
            {
               
                list.Add(new Calls(reader));
            }

            reader.Close();
            dbConn.Close();

            return list;
        }

        public void SaveOrUpdate(Calls record)
        {
            string query = string.Empty;
            if (record.ID == 0)
            {
                // INSERT INTO table (column, column) 
                //            VALUES (value,  value)

               
                query = "INSERT INTO tblCallCentre (CallName, CallNumber, TelcoID, Rating, Comments)";
                query += $"VALUES ('{record.Name}', '{record.Number}', {record.Telco}, {record.Rating}, '{record.Comment}')";
            }
            else
            {
                // UPDATE table SET column = value, column = value WHERE id = x
                query = "UPDATE tblCallCentre " + // ensure there's a space after tblCallCentre
                        $"SET CallName = '{record.Name}'," +
                        $"CallNumber = '{record.Number}'," +
                        $"TelcoID = {record.Telco}, " + // make sure there's a space
                       $"Rating = {record.Rating}, " +
                       $"Comments = '{record.Comment}' " +

                       $"WHERE CallID = {record.ID} ";
            }

            DatabaseManager db = new DatabaseManager();
            OleDbConnection dbConn = db.GetOpenedConnection();
            OleDbCommand dbCmd = new OleDbCommand(query, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();
        }
    }
}
