using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CallDataLayer
{
    public class NameAndTelcoNameManager
    {
        public List<NameAndTelcoName> Search(string term)
        {
            DatabaseManager db = new DatabaseManager();
            OleDbConnection dbConn = db.GetOpenedConnection();

            string query = $"SELECT * FROM qryNamesAndTelcos WHERE CallName LIKE '%{term}%' OR CallNumber LIKE '%{term}%' OR TelcoName LIKE '%{term}%' OR CallID LIKE '%{term}%'";

            OleDbCommand dbCmd = new OleDbCommand(query, dbConn);

            List<NameAndTelcoName> list = new List<NameAndTelcoName>();
            OleDbDataReader reader = dbCmd.ExecuteReader();


            while (reader.Read())
            {
                // long way better for debugging
               

                // short way less typing
                list.Add(new NameAndTelcoName(reader));

            } // end of while

            reader.Close();
            dbConn.Close();


            return list;
        }
    }
}
