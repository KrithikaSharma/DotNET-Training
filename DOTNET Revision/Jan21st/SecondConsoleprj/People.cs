using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleprj
{
    class Person
    {
       protected string name;
        string address;
        int age;
    }

    class Doctor:Person
    {
       protected string category;
        public void func1()
        {
            name = "Sreejith";
            category = "Cardiology";
            
        }
    }
    class DutyDoctor :Doctor
    {
        string Hospital;

        public void func2()
        {
            name = "Rajesh";
            category = "pediatric";
            Hospital = "Apollo";
        }
    }
}
