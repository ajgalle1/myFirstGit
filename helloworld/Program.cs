using System;

namespace helloworld
{
    enum Make { Ford, Chevrolet, Toyota, Mazda };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string VIN = "1G1A888";
            int year = 1989;
            Make make = Make.Ford;
            string model = "Corsica";
            double mileage = 1234.7;
            bool isFourWheel = false;

            Console.WriteLine(make);
        }
    }
}
