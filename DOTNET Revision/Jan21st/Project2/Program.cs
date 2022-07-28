using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondConsoleprj;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            PartOOPs partoops = new PartOOPs();
            int retval=partoops.add(5, 10);
            Console.WriteLine("The sum of 5, 10 is:"+ retval);
            Console.Read();
        }
    }
}
