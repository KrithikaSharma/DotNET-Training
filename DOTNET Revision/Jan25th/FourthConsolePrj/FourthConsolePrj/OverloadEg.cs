using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthConsolePrj
{
    class OverloadEg
    {
        public static void swap(int num1, int num2)  //5,6
        {
            Console.WriteLine("Swap with 2 int arguments");
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            //or
            //int temp = num1;
            //num1 = num2;
            //num2 = temp;
            Console.WriteLine($"After Swapping of 2 integers, num1={num1} and num2={num2}");

        }

        public static void swap(char c1, char c2)
        {
            char temp = ' ';
            temp = c1;
            c1 = c2;
            c2 = temp;
            Console.WriteLine($"After Swapping of Characters, c1={c1} and c2={c2}");
        }

        static void Main()
        {

            //swap(5,4); //pls jump to line no.11 //binding
            //Console.WriteLine("-------------");
            //swap('a', 'b'); //pls jump to line no.26
            Console.WriteLine("--------Overriding---------------");
            Shapes s = new Shapes();
            s.Message("Shape Base");
            s = new Square(); //co variance
            s.Message("Squares Message");
            s = new Traiangle();
            s.Message("Traingles Message");
            Console.Read();
        }
    }

    class Shapes
    {
        public virtual void Message(string s)
        {
            Console.WriteLine($"Message from Shapes Class {s}");
        }
    }

    class Square : Shapes
    {
        public override void Message(string s)
        {
            //base.Message(s);
            Console.WriteLine($"Message from Square Class{s}");
        }
    }

    class Traiangle : Shapes
    {
        public override void Message(string s)
        {
            //  base.Message(s);
            Console.WriteLine($"Message from Traingle class {s}");
        }
    }
}
