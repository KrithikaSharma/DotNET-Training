using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Feb1
{

    class Files2
    {
        public void ReadData()
        {

            FileStream fs = new FileStream("myfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader strRdr = new StreamReader(fs);

            //position the file pointer at the beginning of the file
            strRdr.BaseStream.Seek(0, SeekOrigin.Begin);

            //read till the end of file
            string str = strRdr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = strRdr.ReadLine();
            }
            strRdr.Close();
            fs.Close();

        }
        public void WriteData()
        {
            FileStream fswrt = new FileStream("myfile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter strWrtr = new StreamWriter(fswrt);
            Console.WriteLine("Enter data that u want to write to file...");
            string data = Console.ReadLine();
            strWrtr.WriteLine(data);
            strWrtr.Flush();
            strWrtr.Close();
            fswrt.Close();
        }

        public void DirectoryFileInfo()
        {
            DirectoryInfo dirinfo = new DirectoryInfo("Feb1TestDir");
            if (dirinfo.Exists)
            {
                Console.WriteLine("Directory already exists");
            }
            else
            {
                dirinfo.Create();
                Console.WriteLine("Directory Created");
            }
        }
        public void GetDirectories()
        {
            // code to get all subdirectories
            DirectoryInfo mydirobj = new DirectoryInfo(@"C:\Users\sm59412\source\repos");
            if (mydirobj.Exists)
            {
                DirectoryInfo[] dirs = mydirobj.GetDirectories();
                foreach (object dirnames in dirs)
                {
                    Console.WriteLine(dirnames.ToString());
                }
            }
            else
            {
                Console.WriteLine("The given directory doesnot exists");
            }
        }
        public void GetFiles()
        {
            // code for getting all files inside the directory
            DirectoryInfo mydirobj = new DirectoryInfo(@"C:\Users\sm59412\source\repos")
            FileInfo[] f = mydirobj.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("Filename: {0}, Size: {1}", file.Name, file.Length);
            }
        }

        static void Main()
        {
            Files2 f2 = new Files2();
            //f2.ReadData();
            //f2.WriteData();
            f2.DirectoryFileInfo();

            Console.Read();
        }

    }
}

