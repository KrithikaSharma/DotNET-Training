using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_usages
{
    class Program
    {
        static void Main(string[] args)
        {
            //primitive datatypes are implemented using structs hence memeory implentations and r known as value types
            // we can acesss variables and method without creating objects i.e., without instantiation
            Console.WriteLine("value of pi is: "+MyMaths.PI);
            Console.WriteLine("Area of circle with radius 5 is: " + MyMaths.circleArea(5));

            Rectangle r = new Rectangle(7,8);
            //r.width = 4;
            //r.height = 5

            r.AreaofRectangle();

            int x = (int)Season.SPRING;
            int y = (int)Season.SUMMER;
            int z = (int)Season.WINTER; 

            Console.WriteLine("Spring= {0}",x);
            Console.WriteLine("Summer= {0}",y);
            Console.WriteLine("Winter= {0}",z);
        }
    }
}
