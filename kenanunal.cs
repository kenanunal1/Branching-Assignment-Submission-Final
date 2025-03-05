// Package Express Shipping Cost Calculator
// Developer: Lisa Thompson
// Version: 2.1.0
using System;

namespace ExpressDelivery
{
    public class PackageProcessor
    {
        static void Main(string[] args)
        {
            // Show program introduction
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Collect package weight
            Console.WriteLine("Please enter the package weight:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal weightValue))
            {
                Console.WriteLine("Invalid input. Program terminated.");
                return;
            }

            // Weight validation
            if (weightValue > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Get package dimensions
            decimal[] dimensions = new decimal[3];
            string[] dimensionNames = { "width", "height", "length" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please enter the package {dimensionNames[i]}:");
                if (!decimal.TryParse(Console.ReadLine(), out dimensions[i]))
                {
                    Console.WriteLine($"Invalid {dimensionNames[i]} input. Program terminated.");
                    return;
                }
            }

            // Sum of all dimensions
            decimal totalSize = dimensions.Sum();

            // Size validation
            if (totalSize > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate shipping cost
            // Cost formula: (width * height * length * weight) / 100
            decimal finalCost = (dimensions[0] * dimensions[1] * dimensions[2] * weightValue) / 100;

            // Display shipping cost
            Console.WriteLine($"Your estimated total for shipping this package is: ${finalCost:F2}");
            Console.WriteLine("Thank you!");
        }
    }
} 