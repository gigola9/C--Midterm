using Midterm.Model;
using System;
using System.Collections.Generic;

namespace Midterm
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Commercial first = new Commercial()
            {
                Name = "First",
                ActiveUntil = 10,
                Date = DateTime.Now,
                Factory = "Apple",
                InstalationDate = DateTime.Now,
                Price = 45.3
            };
            Experimental second = new Experimental()
            {
                Name = "Second",
                Date = DateTime.Now,
                InstalationDate = DateTime.Now,
                Factory = "Samsung",
                FreeUntil = 7
            };
            Free third = new Free()
            {
                Name = "Third",
                Factory = "Pixel",
                Date = DateTime.Now,
            };
            Free fourth = new Free()
            {
                Name = "Fourth",
                Factory = "One Plus",
                Date = DateTime.Parse("Jan 1, 2029"),
            };

            List<Software> data = new List<Software>();
            data.Add(first);
            data.Add(second);
            data.Add(third);
            data.Add(fourth);

            // Print software information
            data.ForEach(item => item.printSoftwareDetails());
            Console.WriteLine("------------");

            // Print software information  by valid date
            data.ForEach(item =>
            {
                if (item.isValid())
                {
                    item.printSoftwareDetails();
                }
            });
        }
    }
}
