using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan31
{
    // constriants on class
    /*
    class MyGenericClass<T> where T is:class
    class MyGenericClass<T> where T is:struct
    */
    class MyGenericClass<T>
    {
        private T genericDataMember;

        public T genericProperty { get; set; }

        public MyGenericClass(T data) //generic constructor
        {
            genericDataMember = data;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type is: {0}, and the value is: {1}",typeof(T).ToString(),genericParameter);
            Console.WriteLine("Return(field) type is: {0}, and the value is: {1}", typeof(T).ToString(),genericDataMember);

            return genericDataMember;
        }
    }
    class AllGenerics
    {
        static void Main()
        {
            MyGenericClass<int> mygenericInt = new MyGenericClass<int>(20);
            int returnValue = mygenericInt.genericMethod(200);
            Console.WriteLine("int return value: {0}\n\n",returnValue);

            MyGenericClass<string> mygenericstring = new MyGenericClass<string>("Hello string generics");
            string rv = mygenericstring.genericMethod("invoking string generic method");
            Console.WriteLine("string return value: {0}",rv);

            Console.ReadKey();
        }
    }
}
