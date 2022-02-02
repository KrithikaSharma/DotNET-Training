using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _21Jan_22;


namespace ProjectTakingLink
{
    class Program
    {
        static void Main(string[] args)
        {
            PartOOPs oop = new PartOOPs();
            int retVal=oop.add(5, 10);
            Console.WriteLine("The sum of 5 and 10 is: "+ retVal);
            Console.Read();

        }
    }
}
