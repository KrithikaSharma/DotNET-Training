using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OverloadEg
    {
        public static void swap(int num1,int num2)
        {
            Console.WriteLine("swap with 2 int arguments");
            Console.WriteLine($"Before Swaping num1: {num1} and num2: {num2}");
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine($"After Swaping num1: {num1} and num2: {num2}");
        }

        public static void swap(char c1,char c2)
        {
            Console.WriteLine("swap with 2 charaCters");
            Console.WriteLine($"Before  swapping of characters c1: {c1} and c2: {c2}");
            char temp = ' ';
            temp = c1;
            c1 = c2;
            c2 = temp;
            Console.WriteLine($"After  swapping of characters c1: {c1} and c2: {c2}");
        }

        static void Main()
        {
            swap(4, 9);
            Console.WriteLine("-------------------------------------------------");
            swap('a', 'b');

            Console.WriteLine("---------   overriding   --------------");
            Shapes shp = new Shapes();
            shp.Message("Shape Base");
            shp = new Square(); // co variance
            shp.Message("Squares Message");
            shp.Message("Triangles Message");


            Console.ReadLine();
        }
    }

    class Shapes
    {
        public virtual void Message(string s)
        {
            Console.WriteLine($"Message from Shapes class {s}");
        }
    }

    class Square : Shapes
    {
        public override void Message(string s)
        {
            //base.Message(s);
            Console.WriteLine($"Message from Square class {s}");
        }
    }

    class Triangle : Shapes
    {
        public override void Message(string s)
        {
            //base.Message(s);
            Console.WriteLine($"Message from Triangle class {s}");
        }
    }
}
