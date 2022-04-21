using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.Model
{
    public class Commercial: Software
    {
        public string Name { get; set; }
        public string Factory { get; set; }
        public override DateTime Date { get; set; }
        public double Price { get; set; }
        public DateTime InstalationDate { get; set; }
        public int ActiveUntil { get; set; }

        public override void printSoftwareDetails()
        {
            Console.WriteLine($"Software type is: {Name}");
        }

    }
}
