using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.Model
{
    public class Commercial: Software
    {

        public DateTime InstalationDate { get; set; }
        public int ActiveUntil { get; set; }
        public double Price { get; set; }

        public override void PrintSoftwareDetails()
        {
            Console.WriteLine($"Details - Name: {Name}, Factory: {Factory}, Date: {Date}, Instalation Date: {InstalationDate}, Price: {Price}, Activation Months: {ActiveUntil}");
        }
        public override bool IsValid(DateTime time)
        {
            if (InstalationDate.AddMonths(ActiveUntil) > time)
            {
                return true;
            }
            return false;
        }
    }
}
