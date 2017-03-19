using System;
using CSharpLib;

namespace csharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var bike = new Bike(10, new Person(80));
            Console.WriteLine($"total weight of bike is: {VehicleWeightCalculator.GetTotalWeight(bike)}");

            var car = new Car(1000, new Person(80), new[] { new Person(75) });
            Console.WriteLine($"total weight of car is: {VehicleWeightCalculator.GetTotalWeight(car)}");

            Console.ReadKey();
        }
    }
}
