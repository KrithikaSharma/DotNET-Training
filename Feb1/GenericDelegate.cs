using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1
{
    //generic delegate 
    public delegate T Trans<T>(T arg);

    class Utility
    {
        public static void Transform<T>(T[] values,Trans<T> t)
        {
            for(int i=0; i<values.Length;i++)
            {
                values[i] = t(values[i]); //invoking a delegate
            }
        }
    }
    class GenericDelegate
    {
        static void Main()
        {
            /*
            //------ invoking int delegete
            int[] val = new int[] { 4, 5, 6 };
            Utility.Transform(val, Square);
            foreach (var item in val)
            {
                Console.Write(item+ "  ");
            }
            */

            //-------invoking string delegate
            string[] fruits = new string[] { "Watermelon", "Pineapple", "Mango", "CustardApple", "Guava", "Kiwi" };
            Utility.Transform(fruits, retFruitLength);
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        static int Square(int x)
        {
            return x * x;
        }

        
        static string retFruitLength(string f)
        {
            Console.WriteLine(f.Length);
            return f;
        }
        
    }
}
