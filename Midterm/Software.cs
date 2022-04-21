using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public abstract class Software
    {
        public abstract void printSoftwareDetails();

        public abstract DateTime Date { get; set; }
        public bool isValid()
        {
            if (DateTime.Now < Date)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
