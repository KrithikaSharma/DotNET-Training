using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan24
{
    class ParentClass
    {
        public int parentdata;

        internal ParentClass(int data)
        {
            parentdata = data;
        }
    }
    class Child:ParentClass
    {
        public int childdata;

        // one parameter constructor that initializes both the parent data as well as childata
        internal Child(int cdata):base(cdata) //initilizing the Parent(base) class through the child class constructor
        {
            childdata = cdata; //same data child and parent will have
        }

        public Child(int cdata,int pdata):base(pdata)
        {
            childdata = cdata;

        }
    }
    class BaseDerived
    {
        static void Main()
        {
            //Child c = new Child(20);
            Child c = new Child(20,30);
            Console.WriteLine("Child data is: "+c.childdata);
            Console.WriteLine("Parent Data is: "+c.parentdata);
            Console.ReadLine();
        }
    }
}
