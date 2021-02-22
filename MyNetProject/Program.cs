using System;
using System.IO;


namespace MyNetProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!-  this is now partly modified");
            string line;
            FileStream aFile = new FileStream("C:/Csharp/Alina/Alina.Jon/SalesRecords.csv", FileMode.Open);
            StreamReader sr = new StreamReader(aFile);
            
            // read data in line by line
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }


}


