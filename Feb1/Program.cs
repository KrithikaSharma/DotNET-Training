using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1
{
    class Program
    {
        
        delegate void Print(int val);
        static void Main(string[] args)
        {
            //Anonymous methods
            Print p = delegate (int x) { Console.WriteLine("Inside Anonymous method.Value: {0}", x); };  //can be called only once --?
            p(100);
            /*
            p(1234);
            */

            // Anonyoumous method can access variables defined in an outer fun'n
            int z = 10;
            Print prnt = delegate (int y) { y += z;
                Console.WriteLine( "Anonymous method accesing outside variable {0}",y);
            };
            prnt(10); //invoking the anonymous method thru the delegate obj

            /*
            Print p1 = new Print(Sample); // can be called any no of times
            p1(200);
            p1(300);
            p1(400);
            */

            Console.Read();
        }

        public static void Sample(int c)
        {
            c = c + 100;
            Console.WriteLine("inside testing");
            Console.WriteLine(c);
            testfunc();
            // p(289); //not recognizing p..to call we need to rewrite the anonymous fun'n here
        }

        public static void testfunc()
        {
            Console.WriteLine("inside testing");
        }
    }
}
