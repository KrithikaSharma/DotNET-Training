using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31
{
    public delegate void Multidelegate();
    public delegate int multiretdelegate(int a);
    class MulticastDelegate
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1 invoked");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2 invoked");
        }

        public static void Method3()
        {
            Console.WriteLine("Method 3 invoked");
        }

        class TestMultiretdelegate
        {
            static int p;
            public int Square(int x)
            {
                p = x * x;
                return p;
            }

            public int Tripple(int q)
            {
                p = q * q * q;
                return p;
            }
        }
        static void Main()
        {
            Console.WriteLine("One way of multicasting");
            Multidelegate m1, m2, m3, m4;
             m1 = new Multidelegate(Method1);
             m2 = new Multidelegate(Method2);
             m3 = new Multidelegate(Method3);
             m4 = m1 + m2 + m3; // one way of multicasting
             m4(); //invoking the delegate




            Console.WriteLine("\nSecond way of multicasting");
            Multidelegate md = new Multidelegate(Method1);
            md += Method2;
            md += Method3;//second way of multicasting
            md();
            Console.WriteLine("===================================================");
            md -= Method2; //removing one reference
            md();

            Console.WriteLine(" ------   Multicast with return type  -------------");
            TestMultiretdelegate tmd = new TestMultiretdelegate(); //class object created
            multiretdelegate mrdelegate = new multiretdelegate(tmd.Square);
            mrdelegate += tmd.Tripple;
            int retval = mrdelegate(5);
            Console.WriteLine("retval: "+retval);


            Console.ReadLine();

        }
    }
}
