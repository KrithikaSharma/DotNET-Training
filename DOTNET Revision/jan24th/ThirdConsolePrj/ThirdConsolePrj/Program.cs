using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsolePrj
{
    class Student
    {
        private string RollNo;
        string Name;
        string Class;
        //internal Student() //parameter less constructor that matches the default constructor signature
        //{
        //    Console.WriteLine("Hi Student Class Here");
        //}

        public Student(string rollno, string name, string classno)
        {
            RollNo = rollno;
            Name = name;
            Class = classno;
            Console.WriteLine(RollNo + Name + Class);
        }

        public void GetData()
        {
            Console.WriteLine("Enter Roll No:");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class");
            Class = Console.ReadLine();

        }

        public void PutData()
        {
            Console.WriteLine("Name of Student=" + Name);
            Console.WriteLine("Rolleno="+ RollNo);
            Console.WriteLine("Class=" + Class);
        }
    }
    class Marks:Student
    {
        protected int[] a = new int[5];

        public Marks(string s, string s1, string s2) : base(s, s1, s2)
        {

        }
        public void GetMarks()
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write("Enter Subject {0} Marks:",i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for(int i=0; i<a.Length;i++)
            {
                Console.WriteLine("Marks in subject {0} :{1}", i+1, a[i]);
            }    
        }
    }

    class Result:Marks
    {
        int TotalMarks = 0;

        public Result(string str, string str1, string str2):base(str,str1,str2)
        {

        }
        public void GetResult()
        {
            for(int i=0; i<a.Length;i++)
            {
                TotalMarks = TotalMarks + a[i];
            }
        }

        public void DisplayResult()
        {
            Console.WriteLine("=============Result==============");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks =" + TotalMarks);
        }
        //destructor
        ~Result()
        {
            Console.WriteLine( "Bye from Result");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Result result = new Result("S100","Zensar","Corporateclass");
            result.GetData();
            result.GetMarks();
            result.GetResult();
            result.DisplayResult();
            result = null;
            GC.Collect(); // comes forciblilly
            Console.Read();
        }
    }
}
