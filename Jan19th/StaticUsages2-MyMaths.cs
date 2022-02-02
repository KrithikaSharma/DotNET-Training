using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_usages
{
    public static class MyMaths
    {
        public static float PI = 3.1415f;
        public static float gst;
        public static float circleArea(float r)
        {
            return PI * r * r;
        }
        static MyMaths()
        {
            gst = 18f;
            Console.WriteLine("Inside static constructor");
        }
    }

    public struct Rectangle
    {
        public int width, height;

        public Rectangle(int w,int h)
        {
            width = w;
            height = h;
        }
        public void AreaofRectangle()
        {
            Console.WriteLine("Area of Rectangle is:"+(width*height));
        }
    }

    public class TestStructs
    {
        public static void Display()
        {
            Console.WriteLine(" Inside display of struct ");
        }
    }

    public enum Season
    {
        //fixed set of constant helps in implementing type safety
        WINTER, SPRING, SUMMER, FALL
    };

    public enum Days
    {
        Sun,Mon,Tue,Wed,Thu,Fri,Sat
    };
}
