using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using CsvHelper;

namespace AlinaJon
{
    public class GetFile
    {
        public static void AccessFile()
        {
            string path = "C:/Csharp/Alina/Alina.Jon/SalesRecords.csv";
            
            //MAYBE EXTRACT THIS INTO A METHOD OUTSIDE OF AccessFIle
            
            var salesRecords = ReadCSV(path);

            //TEST some LINQ commands herE
           
            //OrderBy returns an IEnumerable. Use just OrderBy for ascending order
            salesRecords = salesRecords.OrderBy(x => x.Region).ThenByDescending(x => x.TotalProfit).ToList();

            //Filter the list
            salesRecords = salesRecords.Where(x => x.Region == "Europe" && x.OrderDate.Month == 3).OrderByDescending(x => x.TotalProfit).ToList();

            //Filter the list - can use this together with a group by.

           //int totalprofit = salesRecords.Where(x => x.Region == "Europe" && x.OrderDate.Month == 3).Sum(x => x.TotalProfit);

            //TRY FILTERING ON ENUM TO SEE IF IT WORKS

            //Display all records in the list
            foreach (var saleRecord in salesRecords)
            {
                Console.WriteLine($"{saleRecord.Region}, {saleRecord.TotalProfit}, {saleRecord.TotalCosts}, {saleRecord.OrderDate}");
            }
        }

        //Method for parsing the CSV into a list
        private static List<SaleRecord> ReadCSV(string path)
        {
            return File.ReadAllLines(path).Skip(1).Where(row => row.Length > 0).Select(SaleRecord.ParseRow).ToList();
        }
    }
}