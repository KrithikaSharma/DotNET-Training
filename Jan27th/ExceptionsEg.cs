using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27th
{
    class ExceptionsEg
    {
        static void Main()
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 2 nos: ");
                a = Convert.ToInt32(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                int[] arr = { 1, 2, 3, 4 };
                Console.WriteLine("printing index which is not there: "+arr[6]);
                Console.WriteLine(c);
            }
            /*
            catch (DivideByZeroException dbz)
            {
                Console.WriteLine(dbz.Message);
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Stack trace:  "+fe.StackTrace+"\nmessage: "+fe.Message+"\nsource: "+fe.Source);
                Console.WriteLine("Enter only positive integers!!");
            }
            catch(IndexOutOfRangeException ioore)
            {
                Console.WriteLine("Your are trying to read beyond ur capacity!!");
            }
            */
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
