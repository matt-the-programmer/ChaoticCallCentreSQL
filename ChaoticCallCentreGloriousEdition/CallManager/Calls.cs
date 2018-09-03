using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallData

{

    [Serializable]
    public class Calls
    {

        public string Name { get; set; }

        public string Number { get; set; }

        public string Telco { get; set; }

        public int Rating { get; set; }

        public string Comments { get; set; }


        public Calls()
        {
            this.Name = string.Empty;
            this.Number = string.Empty;
            this.Telco = string.Empty;
            this.Rating = 0;
            this.Comments = string.Empty;


        }
    }
}
