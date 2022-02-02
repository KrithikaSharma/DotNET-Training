using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Feb1
{
    // decorator
    [Serializable] // indicates that the below class object can be serialized
    class Files1
    {
        public int ID;
        public string Name;

        static void Main()
        {
            Files1 fobj = new Files1();
            fobj.ID = 1;
            fobj.Name = "Dot NET";
            //write to a file using binary formatter
            BinaryFormatter bf = new BinaryFormatter();
            Stream strm = new FileStream("DataFile.txt",FileMode.Append,FileAccess.Write);
            bf.Serialize(strm, fobj);
            strm.Close();

            //read from a file using binary formatter
            strm = new FileStream("DataFile.txt", FileMode.Open, FileAccess.Read);

            Files1 newfileobj = (Files1)bf.Deserialize(strm);

            

            Console.Read();
        }
    }
}
