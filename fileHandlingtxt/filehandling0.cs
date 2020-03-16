


using System;
using System.IO;




namespace fileHandling
{
    class fileHandling
    {
        static void Main(string[] args)
        {
            string lineIn;




            FileStream fs = new FileStream(@"C:\Users\konra\OneDrive - Institute of Technology Sligo\Modules\Year 1\Semester 2\Programming 2 sem2 yr1\fileHandling1\readThis.txt", FileMode.Open, FileAccess.Read);

            StreamReader inputStream = new StreamReader(fs);

            lineIn = inputStream.ReadLine();

            Console.WriteLine(lineIn);

            inputStream.Close();

        }
    }
}