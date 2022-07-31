using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsolePrj
{
    public class products
    {
        int ProductId; //no access outside the class
        internal protected float ProductPrice; //accessible only within the class and all derived classes
        public string ProductName;//accessible anywhere
        protected internal int Qty;

        public void display()
        {
            ProductId = 101;
            Console.WriteLine(ProductId);
        }

    }
    class AcessSpecifiersEg : products
    {
        static void Main()
        {
            
            AcessSpecifiersEg acc = new AcessSpecifiersEg();
            acc.ProductName = "Desktop";
            acc.ProductPrice = 25000.50f;
            
        }
    }

    class Test
    {
        public void TestFunc()
        {
            products prod = new products();
            prod.ProductName = "Laptop";
            prod.ProductPrice = 8.0f;
            AcessSpecifiersEg a = new AcessSpecifiersEg();
            a.ProductName = "Iphone";
            a.ProductPrice = 10.50f;
        }
    }
}
