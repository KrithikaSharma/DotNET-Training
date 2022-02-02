using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan24
{
    class Student
    {
        private string RollNo;
        string Name;
        string Class;

        internal Student() //parameter less constructor that matches the default constructor signature
        {
            Console.WriteLine("Hi Student class here!!");
        }
        public void GetData()
        {
            Console.Write("Enter Roll no: ");
            RollNo = Console.ReadLine();
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Class: ");
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("name of student: "+Name);
            Console.WriteLine("roll no: "+RollNo);
            Console.WriteLine("class: "+ Class);
        
        }
    }
    class Marks:Student
    {
        protected int[] a = new int[5];

        public void GetMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter subject{0} marks",i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Marks in subject{0} :{1}",i+1,a[i]);
            }
        }
    }
    class Result:Marks
    {
        int TotalMarks = 0;
        public void GetResult()
        {
            for (int i = 0; i < a.Length; i++)
            {
                TotalMarks = TotalMarks + a[i];
            }
        }

        public void DisplayResult()
        {
            Console.WriteLine("-----------   Result   ------------");
            PutData();
            PutMarks();
            Console.WriteLine("Total marks: "+TotalMarks);
        }


        ~Result()
        {
            Console.WriteLine("Bye from Result");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Result r = new Result();
            r.GetData();
            r.GetMarks();
            r.GetResult();
            r.DisplayResult();
            r = null;
            GC.Collect();
            Console.Read();
        }
    }
}
