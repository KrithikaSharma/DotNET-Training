using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Date and Time");
            var date=DateTime.Now.Day;
            Console.WriteLine($"Current Date is {date}");
            var d = new DateTime(2022, 7, 01, 11, 10, 30);
            Console.WriteLine("Day: {0}", d.Day);
            Console.WriteLine("Month: {0}", d.Month);
            Console.WriteLine("Year: {0}", d.Year);
            Console.WriteLine("Hours: {0}",d.Hour);
            Console.WriteLine("Minutes: {0}",d.Minute);
            Console.WriteLine("Seconds: {0}",d.Second);

            Console.WriteLine("Day of the week: {0}",d.DayOfWeek);
            Console.WriteLine("Day of the year: {0}", d.DayOfYear);
            //Console.WriteLine("Time of the Day")

            //Tuesday, 18 January 2022
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            
            // 2022-01-18 12:20:20
            Console.WriteLine(DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss"));

            //Tue, 18 JAN 2022 12:30:20PM GMT
            Console.WriteLine(DateTime.Now.ToString("ddd, dd MMM yyyy hh:mm:ss:tt 'GMT' "));

            
        }
    }
}
