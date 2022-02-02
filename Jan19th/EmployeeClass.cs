using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Employee_class
{
    /*
        public class Program : Employee
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee("Zensar");
                Employee e2 = new Employee("Zensar");

                e1.GetData("Krithika", 9876543210, "kri@zensar.com", "Jr software engineer", "India", new DateTime(30 / 07 / 2012));
            }
        }
         */
    public class Employee
    {
        string name;
        long mobileNo;
        string email;
        string desig;
        string companyName;
        string country;
        string dob;
        public Employee(string c)
        {
            companyName = c;
        }
        public void GetData(string n, long mb, string e, string d, string cntry, string db)
        {
            name = n;
            mobileNo = mb;
            email = e;
            desig = d;
            //companyName = cmpy;
            country = cntry;
            dob = db;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Employee Name: {name} \n Emp mobile no: {mobileNo} \n Emp Email id: {email} \n Emp Designation: {desig} \n Emp company Name: {companyName} \n  Emp country: {country} \n Emp Date of birth: {dob} \n");
            //Console.WriteLine($"Employee Name: {name} \n Emp mobile no: {mobileNo} \n Emp Email id: {email} \n Emp Designation: {desig} \n Emp company Name: {companyName} \n  Emp country: {country} \n Emp Date of birth: {dob} \n");
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Zensar");
            Employee e2 = new Employee("TCS");

            Console.WriteLine("Employee e1 details:");
            e1.GetData("Krithika", 9876543210, "kri@zensar.com", "Jr software engineer", "India", "3-08-2019");
            e1.DisplayData();

            Console.WriteLine("Employee e2 details:");
            e2.GetData("KSharma", 9876123450, "k.sharma@zensar.com", "devops engineer", "Australia", "23 / 02 / 2003");
            e2.DisplayData();


        }

    }
}
