using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28th
{
    class StaticEg
    {
        // let's declare and initialize(use) the static data member
        private static int val1= 5;

        public StaticEg()
        {
            Console.WriteLine("StaticEg normal(nonstatic) constructor");
        }
        public static int Value
        {
            get { return val1; }
        }

        public static void PrintVal()
        {
            Console.WriteLine("Static Eg Class.val1: "+val1);
        }
    }
    class StaticEg2
    {
        private static int val1;

        //static constructor
        static StaticEg2()
        {
            if(StaticEg2.val1<10)
            {
                val1 = 25;
            }
            else
            {
                val1 = 100;
            }
            Console.WriteLine("Static constructor for class StaticEg2 called...");
        }
        public static void Print()
        {
            Console.WriteLine("StaticEg2 Class.val1: " + val1);
        }
        static void Main()
        {
            //static method doesn't need object
            StaticEg.PrintVal();
            Print();
            Console.Read();

        }
    }
}
