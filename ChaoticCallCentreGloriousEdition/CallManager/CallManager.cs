using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CallData
{

    public static class CallManager
    {

        public static void SaveCall(Calls call)
        {
            BinaryFormatter formatter = new BinaryFormatter();


            string fileName = "{0}_{1}.bin";
            fileName = string.Format(fileName, call.Name, call.Telco);


            FileStream file = new FileStream(fileName, FileMode.Create);

            formatter.Serialize(file, call);


            file.Close();
        }


        public static Calls LoadCall(string fileName)
        {

            if (File.Exists(fileName))
            {

                BinaryFormatter formatter = new BinaryFormatter();


                FileStream file = new FileStream(fileName, FileMode.Open);


                Calls loadedCall = formatter.Deserialize(file) as Calls;


                file.Close();


                return loadedCall;
            }
            else
            {

                return new Calls();
            }
        }

        public static List<Calls> LoadAllCalls()
        {
            string[] listOfFiles = Directory.GetFiles(Environment.CurrentDirectory, "*.bin");
            List<Calls> theList = new List<Calls>();

            foreach(string file in listOfFiles)
            {
                theList.Add(LoadCall(file));
            }

            return theList;
        }
    }
}
