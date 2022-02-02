using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan24
{
    class Products
    {
        int ProductId;
        protected float ProductPrice;
        public string ProductName;
    }
    class AcessSpecifiers:Products
    {
        static void Main()
        {
            
            AcessSpecifiers ace = new AcessSpecifiers();
            ace.ProductName = "Desktop";
            ace.ProductPrice = 25000.50f;
        }
    }
    class Test
    {
        Products prod = new Products();
        prod
    }
}
