using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28th
{
    class ListEg
    {
        static void Main()
        {
            //generic way of declaring objects
            List<int> mylist = new List<int>();
            mylist.Add(45);
            mylist.Add(20);
            mylist.Add(12);
            foreach (int item in mylist)
            {
                Console.WriteLine(item);
            }

            //hashtables of collections are equal to Dictionary of Generics
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1,"Red");
            dict.Add(2,"Blue");
            dict.Add(5,"Green");
            dict.Add(3,"Yellow");
            dict.Add(9,"Orange");
            dict.Add(4,"White");

            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (String item in dict.Values)
            {
                Console.WriteLine(item);
            }

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.Write(item.Key);
                Console.Write(item.Value);
                Console.WriteLine();
            }
            Console.Read();
        }



    }
}
