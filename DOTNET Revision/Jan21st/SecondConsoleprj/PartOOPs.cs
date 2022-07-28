using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleprj
{
    class Employee
    {
        int Empid;
        string Empname;
        double Salary;
        DateTime DatofJoin;

       //internal Employee()
       // {
       //     Console.WriteLine("I am your Constructor here..");
       // }

       // public Employee(int Empid, string Empname)
       // {
       //     this.Empid = Empid;
       //     this.Empname = Empname;
       // }

       // public Employee(int eid,string ename,double sal,DateTime doj)
       // {
       //     Empid = eid;
       //     Empname = ename;
       //     Salary = sal;
       //     DatofJoin = doj;
       // }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine(Empid + " " +Empname +" "+ Salary +" "+ DatofJoin);
        }

       public void testfunc()
        {//object Initializer
           // Employee emp = new Employee() { Empname = "Rakesh", Empid = 50, Salary = 567864.56, DatofJoin = Convert.ToDateTime("12/10/2021") };
            ShowEmployeeDetails();
           // emp.ShowEmployeeDetails();
           // PartOOPs partoops = new PartOOPs();
        }
    }
     public class PartOOPs
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        static void Main()
        {
            Employee employee = new Employee();//default constructor is provided by the framework
            //employee.testfunc();
            //Console.WriteLine("----------------");
            //Employee e = new Employee(10, "Rama");//invokes 2 parameter constructor
            //e.testfunc();
            //Console.WriteLine("-----------------");
            //Employee e1 = new Employee(20, "Seetha", 45689.67, Convert.ToDateTime("12/12/2021"));
            //e1.testfunc();
            //Employee e2 = new Employee(30, "Geetha", 50689.67, new DateTime(2021,12,20));
            // e2.testfunc();
            employee.testfunc();
            Console.Read();
        }
    }
}
