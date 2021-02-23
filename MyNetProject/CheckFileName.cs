using System;
using System.Collections.Generic;
using System.Text;


namespace AlinaJon
{
    public class CheckFileName
    {
        public static void CheckFile()
        {
            string CorrectFileName = "SalesRecords.csv";
            
            Console.WriteLine("What is the name of the file?");
            string FileName = Console.ReadLine();

            if (FileName == CorrectFileName)
            {
                GetFile.AccessFile();
            }
            else { throw new ArgumentException("File Name not correct!"); }
        }       
    }
}

