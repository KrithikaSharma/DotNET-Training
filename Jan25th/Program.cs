using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan25
{
    class Shape
    {
        protected float r, l, b;

        public Shape(float R)
        {
            r = R;
        }
        public virtual float Area()
        {
            return 3.14f * r * r;
        }

        public virtual float Perimeter()
        {
            return 2 * 3.14f * r;
        }
    }

    class Rectangle : Shape
    {

        public Rectangle(float R, float L, float B) : base(R)
        {
            l = L;
            r = R;
        }
        public void GetLB() //LB-length and breadth
        {
            Console.Write("Enter length: ");
            l = float.Parse(Console.ReadLine());

            Console.Write("Enter breadth: ");
            b = Convert.ToSingle(Console.ReadLine());
        }

        public override float Area()
        {
            return l * b;
        }

        public override float Perimeter()
        {
            return 2 * (l + b);
        }
    }

    class Circle : Shape
    {
        public Circle(float R) : base(R)
        {
            r = R;
        }

        public void GetRadius()
        {
            Console.Write("Enter radius: ");
            r = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            Console.WriteLine(base.Area());
            return 3 * r * r;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2.3f, 4.0f, 3.0f);
            rect.GetLB();
            Console.WriteLine($"Area of rectangle: {rect.Area()}");
            Console.WriteLine($"Perimeter of rectangle: {rect.Perimeter()}");

            Circle c = new Circle(3.5f);
            c.GetRadius();
            Console.WriteLine($"Area of circle: {c.Area()}");
            Console.WriteLine($"Circumference of circle: {c.Perimeter()}");

            Shape s = new Shape(2.0f);
            Console.WriteLine($"Area of shape: {s.Area()}"); //0

        }
    }
}
