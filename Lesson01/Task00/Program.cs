using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task00
{
    class Program
    {
        static void Main(string[] args)
        {
            Address myAddr = new Address();
            myAddr.Index = 1234;
            myAddr.Country = "Spain";
            myAddr.City = "Madrid";
            myAddr.Street = "Sunny";
            myAddr.House = "221-B";
            myAddr.Apartment = "64";

            myAddr.Print();

            Console.ReadKey();
        }
    }
}
