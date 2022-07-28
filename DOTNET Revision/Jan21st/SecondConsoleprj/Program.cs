using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleprj
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //implicitly typed variable
            var v = 23.546f;
            //dynamic type
            dynamic d;
            d = 'a';
            d = 10;

            Console.WriteLine(d);
            //eg .for nullable value type
            int ? num1;//making int a nullable value type
            num1 = 10;
            string s = null;
            int? TicketsOnSale = null;
            int AvailableTickest;
            if(TicketsOnSale==null)
            {
                AvailableTickest = 0;
            }
            else
            {
                AvailableTickest =(int) TicketsOnSale; //or
                //AvailableTickest = TicketsOnSale.Value;
            }
            Console.WriteLine("Available Tickets ={0}",AvailableTickest);
            //null coalescing operator
            int? T_onSale = null;
            int A_tickest = T_onSale ?? 0;
            Console.WriteLine("Available Tickets ={0}", A_tickest);
            Console.Read();
        }
    }
}
