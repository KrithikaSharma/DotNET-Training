using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Jan_22
{
    class StudentSample
    {
        //private fields
        int RollNo;
        string StdName { get; set; } //automatic properties
        //float Marks;

        public float Marks { get; } //directly declaring property without the field
        public int semester { get; set; }
        
        //public properties declaration

        //RegCode is the property extension of RollNO
        public int RegCode //_RollNo or rollno becomes RollNO
        {
            get { return RollNo; }
            set { RollNo = value; }
        }

        public string identity
        {
            get { return StdName; }
            set { StdName = value; }
        }

        public float grades
        {
            get { return Marks; }
        }

        /*
        public float Marks
        {
            get { return Marks; } //readonly property since no set property
        }
        */

        public void Show()
        {
            Console.WriteLine(RollNo+" "+StdName+" "+Marks);
        }
        static void Main()
        {
            StudentSample ss = new StudentSample(); // default framework constructor
            ss.Show();

            // object initialiazation
            //StudentSample ss1 = new StudentSample() { Marks = 75, StdName = "Asha", RollNo = 65884 };
            StudentSample ss1 = new StudentSample() { StdName = "Asha", RollNo = 65884 };
            Tester.CheckingProperties();
            ss1.Show();

            //StudentSample ss2=new StudentSample() { }
            Console.Read();
        }

    }
    class Tester
    {
        public static void CheckingProperties()
        {
            StudentSample studSample = new StudentSample();
            studSample.RegCode = 215; //set
            Console.WriteLine(studSample.RegCode); //get

            //StudentSample obj1 = new StudentSample() { }

            /*
            StudentSample studSamp1 = new StudentSample()
            {
                identity.
            };
            */

            StudentSample s1 = new StudentSample();
            s1.identity = "Zensar";
            //s1.grades = 90; //error since readonly
            Console.WriteLine(s1.identity,s1.grades);
            
        }
    }
}
