using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             ***   Agenda  ***
             1. Collections
             */
            Console.WriteLine("---------------  COLLECTIONS IN C#  -------------");
            Console.WriteLine("-------- 1. List in c# -------");
            List<int> mylist = new List<int>();
            mylist.Add(1340);
            mylist.Add(250);
            mylist.Add(1000);
            mylist.Add(50000);
            Console.WriteLine("mylist.count: {0}",mylist.Count);
            Console.WriteLine("mylist.capacity: {0}",mylist.Capacity);
            // capacity increases in terms of 2 power n where n is the no of elements

            mylist[0] = 5;
            //mylist.Remove(250);
            mylist.Append(50);
            mylist.Sort();
            foreach(var item in mylist)
            {
                Console.WriteLine(item);
            }

            List<string> authors = new List<string>(5);
            
            List<string> s = new List<string>();
            s.Add("cheetah");
            s.Add("frog");
            s.Add("zebra");
            s.Add("annaconda");

            /* error in these 3 lines
            Console.WriteLine("sorting: {0}",s.Sort());
            Console.WriteLine(" reverse: {0}",s.Reverse());
            Console.WriteLine("slicling: {0}",s[1,3]);
            */

            //non-generic type of collection
            Console.WriteLine("--------  2. Stack in c# -------");
            Stack ts = new Stack();
            ts.Push(1001);
            ts.Push(true);
            ts.Push("hello");
            ts.Push(3.1415);

            foreach (var item in ts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(ts.Peek());
            Console.WriteLine(ts.Pop());
            Console.WriteLine(ts.Peek());

             //Console.WriteLine("--------  3. Hash Table in c# -------");
              Hashtable ht = new Hashtable();
              ht.Add(01,"Krithika");
              ht.Add(04,"Babitha");
              ht.Add(09,"Arshiya");
              ht.Add(05, false);
              ht.Add(false, false);
              ht.Add(0, 0);
              // it is sorted based on hash code
              Console.WriteLine("Hash code",ht.GetHashCode());

              ht.Remove(05);
              Console.WriteLine("after removing 05 key");
              foreach(DictionaryEntry item in ht)
              {
                Console.WriteLine(item.Key+"-"+item.Value);
              }
            
            Console.WriteLine("--------  4. Hash set in c# -------");
            HashSet<Int16> set = new HashSet<Int16>();
            set.Add(55);
            set.Add(78);

            Console.WriteLine("Hash Set elements");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------  5. Hash Table in c# -------");
            Dictionary<int, string> myd = new Dictionary<int, string>();

            myd.Add(1, "ARonaldo");
            myd.Add(4, "ARonaldoinho");
            myd.Add(3, "Abeckhem");
            myd.Add(0, "AChetri");
            myd.Add(2, "ANeymar");
            //myd.Add(username, paswword);

            Console.WriteLine("Dictionary elements");
            foreach (var item in myd)
            {
                Console.WriteLine(item);
            }
        }
    }
}
