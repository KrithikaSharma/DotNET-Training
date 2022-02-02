using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1
{
    public delegate string mydel(string str);
    class Event2
    {
        event mydel MyEvent;

        public Event2()
        {
            this.MyEvent += new mydel(this.WelcomeUser);
        }

        public string WelcomeUser(string usrName)
        {
            return "Welcome " + usrName;
        }

        public string Message(string s)
        {
            return s;
        }

        static void Main()
        {
            Event2 evntobj = new Event2();
            string result = evntobj.MyEvent("To events in C#");
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
