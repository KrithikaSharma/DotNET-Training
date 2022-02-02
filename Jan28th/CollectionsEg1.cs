using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Jan28th
{
    class CollectionsEg1
    {
        static void Main()
        {
            /*
            ArrayList al1 = new ArrayList();
            al1.Add(10);
            al1.Add("Krithika");
            al1.Add(25.45f);
            al1.Add(true);
            

            al1.Insert(2, "Sharma");

            foreach (var item in al1)
            {
                Console.WriteLine(item);
            }
            //al1.RemoveAt()
            al1.Add(false);
            al1.Add(65.45);
            al1.Add("AAA");
            al1.Add(25);

            ArrayList al2 = new ArrayList();

            al2.Add(9);
            al2.Add(2);
            al2.Add(6);
            al2.Add(4);
            al1.AddRange(al2);
            Console.WriteLine();

            Console.WriteLine($"Count of elements: {al1.Count} and capacity is: {al1.Capacity}");
            al2.Sort();
            foreach (var item in al2)
            {
                Console.WriteLine(item);
            }
            */

            //Hashtable is a collection that stores data with a key value pair
            /*
            Hashtable ht = new Hashtable();
            ht.Add("E002", "Hanisha");
            ht.Add("E005", "Jyothi");
            ht.Add("E008", "Sakhi");
            ht.Add("E001", "Saikumar");
            ht.Add("E004", "Prakash");
            ht.Add("E009", "Namita");
            ht.Add("E003", null);

            Console.WriteLine("for keys...");
            foreach(string item in ht.Keys)
                Console.WriteLine(item);

            Console.WriteLine("For values....");
            foreach (string item in ht.Values)
            {
                Console.WriteLine(item);
            }

            //inorder to get both keys n values use DictionaryEntry
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key);
                Console.Write(de.Value);
                Console.WriteLine();
            }

            //to search for a particular key
            Console.Write("Enter a key to be searched: ");
            string mykey = Console.ReadLine();
            if(ht.ContainsKey(mykey))
            {
                Console.WriteLine($"{mykey}={ht[mykey]}");
            }
            else
                Console.WriteLine($"{mykey} doesn't exists");

            //to search for particular value
            
            Console.Write("Enter a value to be searched: ");
            string myval = Console.ReadLine();
            if (ht.ContainsValue(myval))
            {
                Console.WriteLine($"{myval}={ht[myval]}");
            }
            else
                Console.WriteLine($"{myval} doesn't exists");

            */
            SortedList sl = new SortedList();
            sl.Add("vb", "visual basic");
            sl.Add("cs", "CSharp");
            sl.Add("ora", "Oracle");
            foreach (var item in sl.Keys)
            {
                Console.WriteLine(item);
            }

            Stack st = new Stack();
            st.Push('A');
            st.Push("abc");
            st.Push(9);
            st.Push(34.5f);
            st.Pop();//removes the last added item in the stack
            Console.WriteLine(st.Peek()); //displays the top element 

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
