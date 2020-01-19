using System;

namespace CelsiusAFahrenheitConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a thermometer value: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write
                ("Select an option: (1) C -> K   (2) K -> C  : ");
            byte a = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            switch(a)
            {
                case 1:
                    Console.WriteLine("{0} C = {1} K", n, n + 273);
                    break;
                case 2:
                    Console.WriteLine("{0} K = {1} C", n, n - 273);
                    break;
            }
            Console.ReadLine();
        }
    }
}
