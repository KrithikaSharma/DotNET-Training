using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1
{
    class FunctionArguments
    {
        public static void StuDetails(string fname, string lname, int age=20, string branch="CSE")
        {
            Console.WriteLine($"Firstname: {fname}\nLastName: {lname}\nAge: {age}\nStream: {branch}");
        }

        public static void Studdtls(string fname, string lname, int age, string branch)
        {

        }
        static void Main()
        {
            StuDetails("Gulshan", "kumar");
            StuDetails("Menka", "Gandhi",56);
            StuDetails("Rohan", "jhoshi",45,"IT");

            Console.Read();
        }
    }
}
