using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Jan_22
{
    class ReadOnlyConstants
    {
        public readonly int myvar1 = 10;
        //public readonly int myvar1;
        public readonly int myvar2;
        public int data = 25;
        public const float PI = 3.1215f; //no meaning even if constant is public
        static int number = 5;

        //internal ReadOnlyConstants(int a,int b)
        internal ReadOnlyConstants(int a)
        {
            // error: PI = 2.178f; since constant 
            //myvar1 = a;
            //myvar2=b;
            myvar2 = a;
            data = 1;
            //number = 10;
            Console.WriteLine("Displaying values of myvar1:{0} and myvar2: {1} and Data: {2}, Number: {3}",myvar1,myvar2,data,number);
        }

        static void Main()
        {
            ReadOnlyConstants rc = new ReadOnlyConstants(100);
            //ReadOnlyConstants rc1 = new ReadOnlyConstants(100,200);
            ReadOnlyConstants rc2 = new ReadOnlyConstants(390);
            rc2.data = 50;
            number = 15;
            Console.WriteLine(number);
            //rc2.myvar1 = 78; //since readonly it will throw error

            //myvar1 = 50; //though it is public we can't set readonly anywhere other than while decalring or in constructor
            Console.Read();
        }
    }
}
