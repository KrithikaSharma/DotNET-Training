using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Classes_and_Objects
{
    class Program
    {
        int id;
        String name;
        string city;
        string country;

        public Program()
        {
            Console.WriteLine("this is a default constructor...will be called automatically when obj is created");
        }

        public Program(string countryValue)
        {
            country = countryValue;
        }

        public void insert(int i, string n)
        {
            id = i;
            name = n;
        }

        public void display()
        {
            Console.WriteLine($"vrs outside main within insert method: {name} and id : {id} and country is: {country} ");
        }
        static void Main(string[] args)
        {
            int no = 34;
            string mname = "Colaba-Mumbai";
            Program p1 = new Program("Indian");
            Program p2 = new Program("USA");
            //p.id = 007;
            //p.name = "james bond";

            p1.insert(89, "Krithika");
            p2.insert(34, "Arshiya");

            p1.display();
            p2.display();
            //Console.WriteLine($"vrs outside main within className: {p.name} and id : {p.id}");
            Console.WriteLine($"inside main vars no: {no} and mname: {mname} ");


        }
    }
}
