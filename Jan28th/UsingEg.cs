using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

//note above namespce
namespace Jan28th
{
    class UsingEg
    {
        static void Main()
        {
            string MultipleLines = @"This is line 1
            this is line 2
            this is line 3 
            line 4 here
            final n 5th line";
            //WriteLine("Hi!!!!!!!");


            // using StreamReader To read from a string obj/var
            /*
            using (var reader = new StringReader(MultipleLines))
            {
                string item;
                do
                {
                    item = reader.ReadLine(); //input is not from keyboard ...it is from reader which is ponting to MultipleLines var
                } while (item != null);
            }
            */

            //using StreamReader To read from a file
            /*
            using(var streamRdr=new StreamReader("C:\\Users\\sm59412\\Desktop\\file.txt"))
            {
                Console.WriteLine(streamRdr.ReadToEnd());
            }
            */

            // above code is similar to below block
            /*
            var sr = new StreamReader("C:\\Users\\sm59412\\Desktop\\file.txt");
            try
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            finally
            {
                if (sr != null)
                    sr.Dispose(); //geting called from IDisposable interface
            }
            */
            using (var mydc = new MyDisplosableClass())
            {
                mydc.DoSomeWork();
            }
            Read();
        }
    }
    public class MyDisplosableClass : IDisposable
    {
        public MyDisplosableClass() //constructor
        {
            Console.WriteLine("Allocating resources...");
        }

        public void DoSomeWork() //normal method
        {
            Console.WriteLine("Iam using alloted resources");
        }

        //implementation of interface method
        public void Dispose() //method called implicitily==automaticaly we didn't call this method anywhere
        {
            Console.WriteLine("Releasing resources");
        }

    }        

}
