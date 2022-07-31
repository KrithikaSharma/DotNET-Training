using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdConsolePrj;

namespace TestingProtectedAccess
{
    class Program :products

    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ProductPrice = 56000.56f;
        }
    }

    class driver
    {
        public void func1()
        {
            products Products = new products();
            Products.ProductName = "Mobiles";
        }
    }
}
