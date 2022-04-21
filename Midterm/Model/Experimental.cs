using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Experimental: Software
    {
        public DateTime InstalationDate { get; set; }
        public int FreeUntil { get; set; }

        public override void PrintSoftwareDetails()
        {
            Console.WriteLine($"Details - Name: {Name}, Factory: {Factory}, Date: {Date}, Instalation Date: {InstalationDate}, Free Until Months: {FreeUntil}");
        }
        public override bool IsValid(DateTime time)
        {
            if (InstalationDate.AddMonths(FreeUntil) > time)
            {
                return true;
            }
            return false;
        }
    }
}
