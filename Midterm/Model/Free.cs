using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Free : Software
    {
        public override void PrintSoftwareDetails()
        {
            Console.WriteLine($"Details - Name: {Name}, Factory: {Factory}, Date: {Date}");
        }
    }
}
