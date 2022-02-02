using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27th
{
    class Authors
    {
        private string[] namesOfAuthor = new string[3];
        private string publisherName;

        //defining indexers
        public string this[int flag]
        {
            get
            {
                string temp = namesOfAuthor[flag];
                return temp;
                // return namesOfAuthor[flag];
            }
            set
            {
                namesOfAuthor[flag] = value;
            }
        }

        public string this[string flag]
        {
            get
            {
                string temp = namesOfAuthor[2];
                return temp;

            }
        }

        public string this[float flag]
        {
            get
            {
                string temp = namesOfAuthor[2];
                return temp;
            }
            set { namesOfAuthor[2] = value; }
        }
        //property declaration for publisher 
    }
    class IndexersEg2
    {
        static void Main()
        {
            Authors auth = new Authors();
            auth[0]="Sydney Sheldom";
            auth[1] = "James Patterson";
            auth[2] = "Danielle Steel";

            Console.WriteLine($"The 3 famous authors of fiction are {auth[0]}, {auth[1]}, {auth[2]} respectively publishing their novels"); // throgh{auth.publisherName} press");
            //auth["0"]="Agatha Christie";
            Console.WriteLine(auth[0]);
            auth[1.0f] = "Hardley chase";
            Console.WriteLine(auth[1.0f]);
            Console.Read();
        }
    }
}
