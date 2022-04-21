using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Free : Software
    {
        public string Name { get; set; }
        public string Factory { get; set; }
        public override DateTime Date { get; set; }

        public override void printSoftwareDetails()
        {
            Console.WriteLine($"Software type is: {Name}");
        }
    }
}
