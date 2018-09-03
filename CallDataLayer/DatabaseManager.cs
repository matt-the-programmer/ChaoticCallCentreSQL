using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CallDataLayer
{
    class DatabaseManager
    {
        const string CONNECTION_STRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ChaoticCallCentreSQL.accdb";

        public OleDbConnection GetOpenedConnection()
        {
            // allows us to easily connect to the database
            // reduces redundant code in the data operations
            OleDbConnection dbConn = new OleDbConnection(CONNECTION_STRING);
            dbConn.Open();
            return dbConn;

        }

        public void ExecuteNonQuery(string query)
        {
            // the methid to run a insert update or delete are the same
            // doesn't matter what tables etc you are working on
            // therefore we can hav this one method here that can run everything
            // provided the query you gave it works
            OleDbConnection dbConn = GetOpenedConnection();
            OleDbCommand dbCmd = new OleDbCommand(query, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();


        }
    }
}
