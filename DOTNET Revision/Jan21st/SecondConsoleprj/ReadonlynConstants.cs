using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleprj
{
    class ReadonlynConstants
    {
        public readonly int myvar1;
        public readonly int myvar2;
        public int data = 25;
        public const float PI = 3.14f;
        static int number = 5;
        internal ReadonlynConstants(int a, int b)
        {
            myvar1 = a;
            myvar2 = b;
            data = 1;
            number = 10;
            Console.WriteLine("Displaying Value of myvar1:{0} ,myvar2:{1} and Data{2}, Number:{3}",myvar1,myvar2,data,number);
        }
        static void Main()
        {
            ReadonlynConstants rc = new ReadonlynConstants(100,200);
            ReadonlynConstants rc2 = new ReadonlynConstants(200, 500);
            rc2.data = 65;
            number = 15;
            
            Console.WriteLine(number+ " "+ PI);
            Console.Read();
        }
    }
}
