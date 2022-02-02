using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feb1
{
    delegate void prints(string s);

    public class PrintExample
    {
        static FileStream fs; //like a paper where something can be written
        static StreamWriter sw; //like a pen obj to write to a stream

        public static void WriteToScreen(string str)
        {
            Console.WriteLine(" the string is: "+str);
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        //public static void sendString(prints ps) // passing delegates as an argument
        //{
        //    ps("This is C# class on delegates"); //invoking delegate
        //}
    }
    class Delegates3
    {
        static void Main()
        {
            prints ps1 = new prints(PrintExample.WriteToScreen);
            prints ps2 = new prints(PrintExample.WriteToFile);

            //PrintExample.sendString(ps1);
            //PrintExample.WriteToFile(ps2);
            Console.Read();
        }
    }

}
