using Midterm.Model;
using System;
using System.Collections.Generic;

namespace Midterm
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            Software[] data = new Software[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("------ Choose category ------");
                Console.WriteLine("1) Commercial");
                Console.WriteLine("2) Experimental");
                Console.WriteLine("3) Free");
                Console.Write("Enter category number: ");
                int selectedType = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(selectedType)
                {
                    case 1:
                        Commercial first = new Commercial();
                        Console.Write("Enter  Name: ");
                        first.Name = Console.ReadLine();
                        Console.Write("Enter  Factory: ");
                        first.Factory = Console.ReadLine();
                        Console.Write("Enter  Activation Date (Month): ");
                        first.ActiveUntil = int.Parse(Console.ReadLine());
                        Console.Write("Enter  Price: ");
                        first.Price = Double.Parse(Console.ReadLine());
                        Console.Write("Enter  Release Date: ");
                        first.Date = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter  Instalation Date: ");
                        first.InstalationDate = DateTime.Parse(Console.ReadLine());
                        data[i] = first;
                        break;
                    case 2:
                        Experimental second = new Experimental();
                        Console.Write("Enter  Name: ");
                        second.Name = Console.ReadLine();
                        Console.Write("Enter  Factory: ");
                        second.Factory = Console.ReadLine();
                        Console.Write("Enter  Free Untli (Month): ");
                        second.FreeUntil = int.Parse(Console.ReadLine());
                        Console.Write("Enter  Release Date: ");
                        second.Date = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter  Instalation Date: ");
                        second.InstalationDate = DateTime.Parse(Console.ReadLine());
                        data[i] = second;
                        break;
                    case 3:
                        Free third = new Free();
                        Console.Write("Enter  Name: ");
                        third.Name = Console.ReadLine();
                        Console.Write("Enter  Factory: ");
                        third.Factory = Console.ReadLine();
                        Console.Write("Enter  Release Date: ");
                        third.Date = DateTime.Parse(Console.ReadLine());
                        data[i] = third;
                        break;
                    default:
                        Console.WriteLine("Wrong category number !!!");
                        break;
                }
                Console.Clear();
            }

            // Print software information
            Console.WriteLine("------ Print Details ------");
            for (int i = 0; i < n; i++)
            {
                data[i].PrintSoftwareDetails();
            }

            // Print software information  by valid date
            Console.Write("Input date: ");
            DateTime flDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("------ Print Valid Softwares ------");
            filterDate(flDate);

            void filterDate(DateTime time) {
                for (int i = 0; i < n; i++)
                {
                    if (data[i].IsValid(time))
                    {
                        data[i].PrintSoftwareDetails();
                    }
                }
            }
        }
    }
}
