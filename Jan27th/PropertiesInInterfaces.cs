using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27th
{
    interface IName
    {
        string Name { get; set; }//property declaration

    }
    class Employee:IName
    {
        string empname;
        //public string Name { get; set; } //automatic implementation of the Name property

        public string Name
        {
            get { return empname; }
            set { empname = value; }
        }
    }

    class Company : IName
    {
        //private int age { get; set; }
        public int age { get; set; } //automatic implementation
        private string _companyname { get; set; }
        public string Name //manual implementation of the Name property
        {
            get { return _companyname; }
            set { _companyname = value; }
        }

        /*
        public int CompanyAge
        {
            get { return age; }
            set { age = value; }
        }
       */
    }
    class PropertiesInInterfaces
    {
        static void Main()
        {
            IName e = new Employee();
            e.Name = "Krithika";

            IName c = new Company();
            c.Name = "Zensar";
            //c.age // not visible since private
            // even tough  age is made public it's still not visible
            Console.WriteLine($"Employee Named: {e.Name} works for: {c.Name}");

            Company comp = new Company();
            //comp.CompanyAge = 13;
            comp.Name = "Arshiya";
            //Console.WriteLine($"Company {comp.Name} is {comp.CompanyAge} years old");
            Console.WriteLine($"Employee Named: {e.Name} works for: {c.Name} which is {comp.age} years old");
            Console.Read();
        }
    }
}
