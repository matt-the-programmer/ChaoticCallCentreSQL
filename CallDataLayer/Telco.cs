using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallDataLayer
{
   public  class Telco
    {
        public int ID { get; set; }
        public string TelcoName { get; set; }

        public Telco()
        {
            // this constructor will set the field in the class to decent defaults
            ID = 0; // 0 is a useful placeholder for database IDs
            TelcoName = ""; // an empty string is a default for the name property

        }
    }
}
