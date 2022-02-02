using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace Jan31
{
    class CalculatorClient
    {
        static void Main()
        {
            CalculatorClass cc = new CalculatorClass();
            Console.WriteLine(cc.AddNum(5, 6));
            
            Console.ReadKey();
        }
    }
}
