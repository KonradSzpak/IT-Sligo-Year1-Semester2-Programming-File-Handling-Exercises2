


using System;
using System.IO;




namespace fileHandling
{
    class fileHandlingSplit
    {
        static void Main(string[] args)
        {
            int salery;
            int totalSalaries=0;
            int count=0;
            string lineIn;
            string[] fields = new string[4];
            string tableFormat = "{0,-10}{1,-10}{2,-10}{3,-10}";

            FileStream fs = new FileStream(@"C:\Users\konra\OneDrive - Institute of Technology Sligo\Modules\Year 1\Semester 2\Programming 2 sem2 yr1\fileHandling1\readThis.txt", FileMode.Open, FileAccess.Read); //finds file

            StreamReader inputStream = new StreamReader(fs);

            Console.WriteLine("Employee Report"); 
            Console.WriteLine(tableFormat, "Name", "Email", "Address", "Salery");

            lineIn = inputStream.ReadLine(); //reads line and goes to next line

            while (lineIn != null) //while next line is not null goes to next line
            {
                fields = lineIn.Split(','); //if there is , it splits it parts and puts it into array "fields"
                salery = int.Parse(fields[3]);  //salery = 4 position of fields
                totalSalaries = totalSalaries + salery; //totalSaleries is 4 position of the array + salery

                Console.WriteLine(tableFormat, fields[0], fields[1], fields[2], fields[3]); // displays table

                lineIn = inputStream.ReadLine(); //goes to next line and reads and repeats process
            }

            int avgSalery = totalSalaries / count;

            Console.WriteLine("Total = {0}", totalSalaries);
            Console.WriteLine("Average = {0}", avgSalery);

            inputStream.Close();

        }
    }
}