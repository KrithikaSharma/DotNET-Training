using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27th
{
    interface Iinterface1
    {
        string Message(string s);
    }

    interface Iinterface2
    {
        string Message(string s);
    }
    class ExplicitInterface:Iinterface1,Iinterface2 
    {
        //public string Iinterface1.Message(string s) 
        string Iinterface1.Message(string s) //interface functions are bydefault public so no need to explicitly mention public while referring to interface  like interface.method
        {
            return "Hello " + s;
        }
        
        public string Message(string s)
        //string Iinterface2.Message(string s) // default implemetation---above is an explicit implementation
        {
            return "Hi " + s;
        }

        static void Main()
        {
            //first way to invoke the methods of the class
            /*
            ExplicitInterface EI = new ExplicitInterface();
            EI.// method not visible
            */

            Iinterface1 ie1 = new ExplicitInterface();
            Iinterface2 ie2 = new ExplicitInterface();
            Console.WriteLine(ie1.Message("Krithika"));
            Console.WriteLine(ie2.Message("Sharma"));

            //Second way of invoking the methods
            ExplicitInterface ei = new ExplicitInterface();
            Console.WriteLine(((Iinterface1)ei).Message("Arshiya"));
            Console.WriteLine(((Iinterface2)ei).Message("Khan"));

            Console.WriteLine(ei.Message("Zensar"));
            Console.Read();
        }
    }
}
