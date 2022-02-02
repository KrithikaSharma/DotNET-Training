using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31
{
    //delegate declaration
    public delegate void EmpHandler(string s);
    public delegate int NumChanger(int a);

    class TestDelegate
    {
        static int num = 30;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiplyNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum() //doesn't match delegate
        {
            return num;
        }
    }
    class Employee
    {
        public static void Accept(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }
        public void Display() //doesn't match delegate
        {
            Console.WriteLine("welcome");
        }
    }
    class Delegates1
    {
        
        static void Main()
        {
            Employee e = new Employee();
            EmpHandler eh1 = new EmpHandler(Employee.Accept); //passing the name of static function to the delegate object
            EmpHandler eh2 = new EmpHandler(e.Show); //passing the name of the public method to the
            eh1("Krithika");
            //or
            eh2.Invoke("Sharma");


            NumChanger nc1 = new NumChanger(TestDelegate.AddNum);
            NumChanger nc2 = new NumChanger(TestDelegate.MultiplyNum);
            //calling delegates
            nc1(25);
            Console.WriteLine($"value of num after addition: {TestDelegate.getNum()}");
            nc2(5);
            Console.WriteLine($"value of num after multiplication: {TestDelegate.getNum()}");

            Console.ReadKey();
        }
    }
}
