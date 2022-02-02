using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28th
{

    //user defined exception class declaration
    class VotingException : ApplicationException
    {
        public VotingException(string msg) : base(msg)
        {

        }
    }
    class Vote
    {
        int age;
        public void AcceptAge()
        {
            Console.Write("Enter ur age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                throw (new VotingException("You are not eligible to vote, age should be greater than 18"));
            }
            else
            {
                Console.WriteLine("Thanks for voting...");
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Vote v = new Vote();
            try
            {
                v.AcceptAge();
            }
            catch(VotingException ve)
            {
                Console.WriteLine("voting exception message: "+ve.Message+"\nsource: "+ve.Source);

            }
            Console.Read();
        }
    }
}
