using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Jan_22
{
    class Employee
    {
        //fields: will be private by default...will not be accessed outside the class this provides abstraction.
        // data members are advisable to be private, and  methods as public. Functions can operate on private data members
        // all classes is by default internal
        internal int EmpId;
        //public int EmpId; : even tough it is public it can't be accessed since cls is not public so not point of having members as public
        // like main gate closed and rest of the rooms are open... even tough rooms are open(public) we can't go insaide since gate(class) is locked(
        string Empname;
        double Salary;
        DateTime DOJ;

        //internal Employee() == Employee()

        internal Employee() //if cls is by default internal then constructor is also internal
        {
            Console.WriteLine("Iam ur Constructor");
        }

        public Employee(int EmpId,string EmpName) //overloading
        {
            this.EmpId = EmpId;
            this.Empname = Empname;
        }

        public Employee(int eid,string ename, double sal, DateTime dtofj)
        {
            EmpId = eid;
            Empname = ename;
            Salary = sal;
            DOJ = dtofj;
        }
        //void ShowEmployeeDetails() //private not accessible outside cls hence making it public
        public void ShowEmployeeDetails()
        {
            Console.WriteLine(EmpId +"" + Empname +" "+Salary+" "+DOJ);
        }

        //static void testFunc() // static within the cls
        //public static void testFunc() 
        public void testFunc()
        {

            Employee e = new Employee();
            //Employee.testFunc();
            ShowEmployeeDetails();  // can be called if its private too since within same cls
            //PartOOPs oop = new PartOOPs();
            e.testFunc();

            Employee emp3 = new Employee()
            {
                //object initializer
                EmpId = 50,
                Empname = "Sharma",
                Salary = 789.23f,
                DOJ = Convert.ToDateTime("04-01-2022")
            };
            

        }
    }
    public class PartOOPs
    {
        // classes cannot be made private
        //fields
        //internal cls will allow to create object but we won't pe able to access private methods and private datafields
        /*
         * Access Specifiers
         * 1. Private: default-accessible only within the cls
         * 2. Public: accessible anywhere but with obj instance, outside assembly too
         * 3. Internal: Accessible anywhere inside the assembly(/namespace/project), restricted outside assembly 
         * - Internal is public within namespace
         * 4. Protected: 
         * 5. ProtectedInternal or InternalProtected: 
         */

        public int add(int x, int y)
        {
            return x + y;
        }
        static void Main()
        {
            Employee e = new Employee(); //default constructor provided by framework
            e.testFunc();
            //e.EmpId; // since internal...only empid is accessbile bcz rest are private

            Employee emp = new Employee(10, "rama");
            Employee emp1 = new Employee(20, "Krithika", 45.78f, Convert.ToDateTime("12/12/2021"));
            emp1.testFunc();

            Employee emp2 = new Employee(20, "Krithika", 45.78f, new DateTime(2021,01,21));
            emp2.testFunc();

            
            Console.Read();
        }
        
    }
}
