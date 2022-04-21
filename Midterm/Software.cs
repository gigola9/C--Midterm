using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public abstract class Software
    {
        public string Name { get; set; }
        public string Factory { get; set; }
        public DateTime Date { get; set; }
        public abstract void PrintSoftwareDetails();
        public virtual bool IsValid(DateTime time)
        {
            return true;
        }
    }
}
