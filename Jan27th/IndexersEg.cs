using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27th
{
    class Employees
    {
        //declaring properties

        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        //constructor to initialize property
        public Employees(int ID,string Name,double Salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.Salary = Salary;
        }

        //defining Indexers
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Name;
                else if (index == 1)
                    return Salary;
                else if (index == 2)
                    return ID;
                else
                    return null;
            }

            //set accessors to assign values
            set
            {
                if (index == 2)
                    ID = Convert.ToInt32(value);
                else if (index == 0)
                    Name = value.ToString();
                else if (index == 1)
                    Salary = Convert.ToDouble(value);
            }
        }

        //overloaded indexer
        public object this[string s]
        {
            get
            {
                if (s == "eid")
                    return ID;
                else if (s == "ename")
                    return Name;
                else if (s == "sal")
                    return Salary;
                else
                    return null;
            }

            set
            {
                if (s == "eid")
                    ID = Convert.ToInt32(value);
                else if (s == "ename")
                    Name = value.ToString();
                else if (s == "sal")
                    Salary = Convert.ToDouble(value);
            }
        }
    }
    class IndexersEg
    {
        static void Main()
        {
            //creating an instance of employees
            Employees emps = new Employees(65884,"KriSh",26750.50);
            //Console.WriteLine("EmployeeId= "+emps[0]); //cannot be done, to do we need to use indexers
            Console.WriteLine($"EmployeeId = {emps[2]}\nName= {emps[0]}\nSalary= {emps[1]}");
            emps[0] = "Krithika";
            emps[1] = 27000;
            emps[2] = 125;
            Console.WriteLine("\n\n-----------  After Modifications  ----------------");
            Console.WriteLine($"EmployeeId = {emps[2]}\nName= {emps[0]}\nSalary= {emps[1]}");
            
            Console.WriteLine("\n\n-----------  Using overloaded indexers  ----------------");
            Employees emp2 = new Employees(201, "Praveen", 12000);
            Console.WriteLine($"EmployeeId = {emp2[2]}\nName= {emp2[0]}\nSalary= {emp2[1]}");
            Console.Read();

        }
    }
}
