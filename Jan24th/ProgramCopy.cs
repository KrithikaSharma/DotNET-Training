using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan24
{
    class StudentCopy
    {
        public string RollNo;
        public string Name;
        public string Class;

        internal StudentCopy(string rno, string n,string cls)
        {
            RollNo = rno;
            Name = n;
            Class = cls;
        }
        
        public void PutData()
        {
            Console.WriteLine("name of student: " + Name);
            Console.WriteLine("roll no: " + RollNo);
            Console.WriteLine("class: " + Class);

        }
    }
    class MarksCopy : StudentCopy
    {
        protected int[] a = new int[5];

        internal MarksCopy(string rno, string n, string cls):base(rno, n, cls)
        {
            //RollNo = rno;
            Console.WriteLine("will see later ...this part");
        }
        public void GetMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter subject{0} marks", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Marks in subject{0} :{1}", i + 1, a[i]);
            }
        }
    }
    class ResultCopy : MarksCopy
    {
        int TotalMarks = 0;

        public ResultCopy(string rno, string n, string cls) : base(rno, n, cls)
        {
            Console.WriteLine("don't know this part!!!!!!!!!!");
        }
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
            Console.WriteLine("Total marks: " + TotalMarks);
        }

    }

    class ProgramCopy
    {
        static void Main(string[] args)
        {
            //Result r = new Result();
            ResultCopy r = new ResultCopy("101","ks","9");
            //r.GetData();
            r.GetMarks();
            r.GetResult();
            r.DisplayResult();
            Console.Read();
        }
    }
}
