using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31
{
    //generic class
    class GenericProperty<T>
    {
        private T mydata; //generic member

        public T Data //generic property
        {
            get { return this.mydata; }
            set { this.mydata= value; }
        }

        //generic method
        public void Display<T>(string msg, T val)
        {
            Console.WriteLine("{0}:{1}",msg,val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // instance of string type
            GenericProperty<string> stringgeneric = new GenericProperty<string>();
            stringgeneric.Data = "I am string type";
            Console.WriteLine($"string generic data: {stringgeneric.Data}");

            stringgeneric.Display<string>("StringType ", "Zensar");

            //instance of float type
            GenericProperty<float> floatgeneric = new GenericProperty<float>();
            floatgeneric.Data = 45.87f;
            Console.WriteLine($"float generic data: {floatgeneric.Data}");

            floatgeneric.Display<float>("FloatType ", 34.5f);

            //instance of int type
            GenericProperty<int> intgeneric = new GenericProperty<int>();
            intgeneric.Data = 536;
            Console.WriteLine($"int generic data: {intgeneric.Data}");

            intgeneric.Display<int>("IntegerType ", 73);

            Console.ReadKey();
        }
    }
}
