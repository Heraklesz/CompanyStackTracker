using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStackTracker
{
    public class Company
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public int EntryValue { get; set; }
        public int ActualValue { get; set; }
        public int Quantity { get; set; }
        public int Deficit { get { return (ActualValue * Quantity) - (EntryValue * Quantity); } }


    }
}
