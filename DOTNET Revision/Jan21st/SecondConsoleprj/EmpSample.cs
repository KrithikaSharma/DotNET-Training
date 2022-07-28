using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleprj
{
    class StudentSample
    {
        //private fields
        int RollNo;
        string StdName { get; set; }  //automatic properties
        public float Marks { get; }

        public int semester { get; set; }

        //public properties declaration
        public int RegCode  //readonly property
        {
            get { return RollNo; }
            //set { RollNo = value; }
        }
        public void Show()
        {
            Console.WriteLine(RollNo+" "+StdName+ " "+Marks);
        }
        static void Main()
        {
            // Below default constructor Will allocate only memory but does not initialize the fields 
            StudentSample ss = new StudentSample(); //invoking default const provided by the framework
            ss.Show();
            // Below is also default constructor here object initialization is possible without the constructor 
            //StudentSample ss1 = new StudentSample() { Marks = 75, StdName = "Aasha", RollNo = 1 };
            StudentSample ss1 = new StudentSample() { RollNo = 6, StdName = "Albert", semester = 3 };
            ss1.Show();
            Tester.CheckingProperties();
            Console.Read();
        }
    }
    
    class Tester
    {
        public static void CheckingProperties()
        {
            StudentSample studsample = new StudentSample() {RegCode=45,semester=1 };
            studsample.RegCode = 215; //set 
            Console.WriteLine(studsample.RegCode); //get
           
        }
    }
    
}
