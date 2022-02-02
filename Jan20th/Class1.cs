using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20thJan_22_Basics
{
    class Employee
    {
        int EmpId;
        string EmpName;
        float EmpSalary;

        public void GetEmp()
        {
            Console.WriteLine("Enter employee Id, Name, Salary: ");
            EmpId = Convert.ToInt32(Console.ReadLine());
            EmpId = int.Parse(Console.ReadLine());
            EmpName = Console.ReadLine();
            EmpSalary = Convert.ToSingle(Console.ReadLine());
            EmpSalary = float.Parse(Console.ReadLine());
        }

        public void ShowEmp()
        {
            Console.WriteLine("Employee Details: \nId={0}, Name={1}, Salary={2}",EmpId,EmpName,EmpSalary);
        }

        public static void Main()
        {
            Employee emp = new Employee();
            emp.GetEmp();
            emp.ShowEmp();
            Console.ReadKey();
        }
    }
}
