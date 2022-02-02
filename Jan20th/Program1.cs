using System;


namespace _20thJan_22_Basics
{
    class Program
    {
        public int Id;
        public string Name;
        DateTime doj;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Id = 5;
            p.Name = "Zensar";
            p.doj = Convert.ToDateTime("04-01-2022");
            Program p1 = new Program();
            p1.Id = 10;
            p1.Name = ".NET";
            Console.WriteLine("Id of the p: {0}, Name of p: {1}, doj of p: {2}",p.Id,p.Name,p.doj); // placeholders
            // above doj time is not given it takes default time as 12:00:00AM
            Console.WriteLine("Id of the p1: "+p1.Id+ ", Name of p1: " +p1.Name+", doj of p1: "+ p1.doj); // Concatination
            // above doj time is not given it takes default time as 12:00:00AM, doj default is taken as 1/1/0001
            Display(); //static method can be called directly without the need of object
            p.TestFunc(); //need object since method is not static
            p1.TestFunc();

            MyClass mc = new MyClass();
            mc.Accept();
            mc.Show();
            
        }
        static public void Display()
        {
            Console.WriteLine("Hello Static");
        }

        public void TestFunc()
        {
            Console.WriteLine("Hello public");
        }
    }
    class MyClass
    {
        static string empname;
        static int empid;
        public void Accept()
        {
            Console.Write("Enter ur name: ");
            empname = Console.ReadLine();
            Console.Write("Enter ur ID: ");
            empid = Convert.ToInt32(Console.ReadLine()); //since ReadLine reads everything as string we need to convert it to int
        }
        public void Show()
        {
            Console.WriteLine($"Emp Id: {empid}, Emp Name is: {empname}");
        }
    }
}
