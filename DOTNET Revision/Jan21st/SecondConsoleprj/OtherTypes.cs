using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleprj
{
   class NewStudent
    {
        public int marks1;
        public int marks2;
    }
    class OtherTypes
    {
        enum Days { Sun,Mon,Tue,Wed,Thur,Fri,Sat};
        static void Main()
        {
            NewStudent s1 = new NewStudent();
            s1.marks1 = 50;
            s1.marks2 = 80;
            Console.WriteLine(s1.marks1 + s1.marks2);

            NewStudent s2 = new NewStudent();
            s2 = s1;
            Console.WriteLine(s2.marks1 +s2.marks2);

            s1.marks1 = 80;
            s1.marks2 = 100;
            Console.WriteLine("After reassigning s1....");
            Console.WriteLine(s1.marks1 + s1.marks2);
            Console.WriteLine(s2.marks1 + s2.marks2);
            int weekstart = (int)Days.Mon;
            int weekend = (int)Days.Fri;
            Console.WriteLine("WeekStart: {0} and Weekend :{1}", weekstart,weekend);
            
             Console.ReadKey();
        }
    }
}
