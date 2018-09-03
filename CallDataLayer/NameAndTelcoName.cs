using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CallDataLayer
{
   public class NameAndTelcoName
    {
        public string CallName { get; set; }
        public string CallNumber { get; set; }
        public string TelcoName { get; set; }
        public int CallID { get; set; }


        public NameAndTelcoName(OleDbDataReader reader)

        {
            CallName = (string)reader["CallName"];
            CallNumber = (string)reader["CallNumber"];
            TelcoName = (string)reader["TelcoName"];
            CallID = (int)reader["CallID"];

        }
    }
}
