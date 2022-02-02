using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28th
{
    class Employee
    {
        int Eid;
        string Ename;
        string Compname;
        float salary;

        public Employee(int id,string ename, string cname, float sal)
        {
            Eid = id;
            Ename = ename;
            Compname = cname;
            salary = sal;
        }

        public override string ToString()
        {
            return $"Emp id: {Eid} with Emp name: {Ename} works with: {Compname} and earn Rs: {salary}";
            //return string.Format("Empid: " + Eid + "Emp name: "+Ename);
        }

        /*
        static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(156, "Krithika", "Zensar", 28.87f));
            emplist.Add(new Employee(123, "Babitha", "Villa teresa", 68.87f));
            emplist.Add(new Employee(147, "Arshiya", "Trinity", 25.87f));

            foreach (Employee e in emplist)
            {
                Console.WriteLine($"Employee id {eid} with Employee name {e.Ename} works with {e.Compname}");
            }
            Console.Read();
        }
        */
    }
    class GenericLists
    {
        static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(156, "Krithika", "Zensar", 28.87f));
            emplist.Add(new Employee(123, "Babitha", "Villa teresa", 68.87f));
            emplist.Add(new Employee(147, "Arshiya", "Trinity", 25.87f));

            foreach (Employee e in emplist)
            {
                //Console.WriteLine($"Employee id {eid} with Employee name {e.Ename} works with {e.Compname");
                Console.WriteLine(e.ToString()); //ToString is virtual and can be overridden
            }
            Console.Read();
        }
    }
}
