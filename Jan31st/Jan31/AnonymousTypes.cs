using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31
{
    class AnonymousTypes
    {
        static void Main()
        {

            var mytype = new
            {
                data1 = "CSharp",
                data2 = 2,
                data3 = true,
                data4 = 56.0998,
                data5 = 45.3f,
                data6='A'
            };

            Console.WriteLine("mytype: "+mytype);
            Console.WriteLine("mytype.ToString(): "+mytype.ToString());

            //lambda expression
            List<int> nos = new List<int>() { 16, 23, 12, 19, 42, 28, 57, 7, 9, 30, 23 };
            foreach (int item in nos)
            {
                Console.WriteLine(item);
            }

            //using lambda to find the square of each element in the collection
            // nos is a collection, Select() is a method, n start from 1st element
            var square = nos.Select(n => n * n);
            Console.WriteLine("squares of the collection...");
            foreach (var item in square)
            {
                Console.WriteLine(item);
            }

            //find all the nos in the list that are divisible by 3
            Console.WriteLine("the nos in the list that are divisible by 3");
            List<int> divby3 = nos.FindAll(m => m % 3 == 0);
            foreach (var item in divby3)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
