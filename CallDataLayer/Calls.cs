using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CallDataLayer
{
    public class Calls
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public int Telco { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public Calls()
        {
            ID = 0;
            Name = string.Empty;
            Number = string.Empty;
            Telco = 0;
            Rating = 0;
            Comment = string.Empty;
        }
            public Calls(int id, string name, string number, int telco, int rating, string comment)
            {
                ID = id;
                Name = name;
                Number = number;
                Telco = telco;
                Rating = rating;
                Comment = comment;
            }

            // creates a Track object using data from a reader
            public Calls(OleDbDataReader reader)
            {
                ID = (int)reader["CallID"];
                Name = (string)reader["CallName"];
                Number = (string)reader["CallNumber"];
                Telco = (int)reader["TelcoID"];
                Rating = (int)reader["Rating"];
                Comment = (string)reader["Comments"];
            }

        }
    }

