using System;

namespace Circle_Objects

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            double userRadius = 0;
            double circlesCreated = 0;
            string answer;

            do
            {
                Console.WriteLine("Please enter the radius of the circle you would like to test:");
                userRadius = double.Parse((Console.ReadLine()));

                if (userRadius <= 0)
                {
                    Console.WriteLine("That is not a valid radius.");
                }

                else
                {
                    circlesCreated++;
                    Circle newCircle = new Circle(userRadius);
                    Console.WriteLine(newCircle.CaclulateFormattedCircumference());
                    Console.WriteLine(newCircle.CalculateFormattedArea());
                }
                Console.WriteLine("would you like to enter another radius?");
                answer = Console.ReadLine().ToLower();

            }
            while (answer == "yes" || answer == "y");
            Console.WriteLine($"Goodbye. You created {circlesCreated} Circle Object(s)");
            Console.ReadKey();
        }
    }
}