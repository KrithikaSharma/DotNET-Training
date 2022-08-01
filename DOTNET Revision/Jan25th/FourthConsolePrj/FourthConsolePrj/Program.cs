using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthConsolePrj
{

    class Shape
    {
        protected float R, L, B;

        public Shape(float r)
        {
            R = r;
            
        }
        // virtual method can be either used as it is ... or can be overridden
        public virtual float Area() //base class allows redefining the method Area() in the child class
        {
            return 3.14f * R * R;  //parent has written the coding to find the area of a circle
        }

        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(float r, float l, float b):base(r)
        {
            L = l;
            B = b;
        }
        public void GetLB()
        {
            Console.Write("Enter Length :");
            L = float.Parse(Console.ReadLine());
            Console.Write("Enter Breadth :");
            B = Convert.ToSingle(Console.ReadLine());
        }
        public override float Circumference()
        {
            return 2 * (L + B);//formula for finding the perimeter/circumference of a rectangle
        }

        public override float Area()
        {
            return L * B;
        }
    }

    class Circle : Shape
    {

        public Circle(float r):base(r)
        {
            R = r;
        }
        public void GetRadius()
        {
            Console.Write("Enter Radius :");
            R = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
           // Console.WriteLine(base.Area()); 
            return 3 * R * R;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle(2.3f,4.0f,3.0f);
           // R.GetLB();
           // float area = R.Area();
            Console.WriteLine("Area of Rectangle {0}",R.Area());
          //  Console.WriteLine("Perimeter of Rectangle {0}",R.Circumference());
            Circle C = new Circle(3.5f);
          //  C.GetRadius();
            float area_of_circle=C.Area();
            Console.WriteLine("Area of Circle is{0}", area_of_circle);
           // Console.WriteLine("Circumference of Circle is {0}", C.Circumference());
            Shape S = new Shape(2.0f);
            Console.WriteLine("Area of Shape is {0}",S.Area()); 

            Console.Read();
        }
    }
}
