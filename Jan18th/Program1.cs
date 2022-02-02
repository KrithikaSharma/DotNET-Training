using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Strings
{
    class Program
    { 
    static void Main(string[] args)
    {
        Console.WriteLine("Working with string...");
        string userName = "KrithikaSharma";
        string datestring = DateTime.Today.ToShortDateString();

        string str = "Hello" + userName + "Today is" + datestring + ".";
        str += "How are you today?";
        Console.WriteLine(str);
        Console.WriteLine("*************************************************************");

        string newString = $"Hello{userName}. Today is {datestring}.";
        Console.WriteLine(newString);

        newString += "How are you today?";
        Console.WriteLine(newString);
        // Note: In c# Null String is treated as empty string

        Console.WriteLine("====================== String Builder Demo============");

        var sb=new System.Text.StringBuilder();
        for (int i = 0;i<20;i++)
        {
            sb.AppendLine(i.ToString());
        }

        System.Console.WriteLine(sb.ToString());

        Console.WriteLine("_________concat() and join()________");
        string[] words = { "The", "Quick", "Brown", "Fox", "Jumps", "Over", "A", "Lazy", "Dog" };
        var unreadablePharse = string.Concat(words);
        Console.WriteLine(unreadablePharse);

        var readablePharse = string.Join("-", words);
        Console.WriteLine("");
    }
}
}
