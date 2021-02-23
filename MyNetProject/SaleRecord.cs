using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace AlinaJon
{
    public class SaleRecord
    {

        enum Priority
        {
            [Display(Name = "critical")]
            C,
            [Display(Name = "high")]
            H,
            [Display(Name = "medium")]
            M,
            [Display(Name = "low")]
            L
        }

        enum Channel
        {
            Offline,
            Online
        }

        public string Region { get; set; }
        public string Country { get; set; }
        public string ItemType { get; set; } // we can put this into class
        public Enum OrderPriority { get; set; }
        public Enum SalesChannel { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderID { get; set; }
        public DateTime ShipDate { get; set; }
        public int UnitsSold { get; set; }
        public double UnitPrice { get; set; }
        public double UnitCost { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalCosts { get; set; }
        public double TotalProfit { get; set; }

        public static SaleRecord ParseRow(string row)
        {
            var fields = row.Split(",");
            return new SaleRecord()
            {
                Region = fields[0],
                Country = fields[1],
                ItemType = fields[2],
                SalesChannel = (Channel)Enum.Parse(typeof(Channel), fields[3]),
                OrderPriority = (Priority)Enum.Parse(typeof(Priority), fields[4]),
                OrderDate = DateTime.Parse(fields[5]),
                OrderID = fields[6],
                ShipDate = DateTime.Parse(fields[7]),
                UnitsSold = int.Parse(fields[8]),
                UnitPrice = double.Parse(fields[9]),
                UnitCost = double.Parse(fields[10]),
                TotalRevenue = double.Parse(fields[11]),
                TotalCosts = double.Parse(fields[12]),
                TotalProfit = double.Parse(fields[13])
            };
        }
    }
}