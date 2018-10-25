using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1:\t");
            double side1;
            Double.TryParse(Console.ReadLine(), out side1);

            Console.Write("Enter side 2:\t");
            double side2;
            Double.TryParse(Console.ReadLine(), out side2);

            Rectangle rec = new Rectangle(side1, side2);

            Console.WriteLine(new string ('-', 20));
            Console.WriteLine("Perimeter:\t" + rec.Perimeter);
            Console.WriteLine("Area:\t\t" + rec.Area);

            Console.ReadKey();
        }
    }
}
