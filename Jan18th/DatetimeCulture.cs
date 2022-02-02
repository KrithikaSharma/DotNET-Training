
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateTime_Demo_culture
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            DateTime currentTime = new DateTime();
            Console.WriteLine("Displaying datetime based on the culture");
            string dateInUSA = currentTime.ToString("D", new CultureInfo("en-US"));
            Console.WriteLine(dateInUSA);

            string dateInHindi = currentTime.ToString("D", new CultureInfo("hi-IN"));
            Console.WriteLine(dateInHindi);

            Console.WriteLine(culture.Calendar);
            Calendar c = new PersianCalendar();
            DateTime dt = new DateTime(2022, 01, 18, c);
            Console.WriteLine("Persian Calender Year",dt.Year);
            Console.WriteLine("Persian Calender Month",dt.Month);
        }
    }
}
