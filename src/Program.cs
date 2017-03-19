using System;
using CSharpLib;

namespace csharp7
{
    public static class TupleExtension
    {
        public static string ForOutput(this (int weight, Result result) r)
        {
            return r.result.OK ? r.weight.ToString() : r.result.Message;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var bike = new Bike(10, new Person(80));
            Console.WriteLine($"total weight of bike is: {VehicleWeightCalculator.GetTotalWeight(bike).ForOutput()}");

            var car = new Car(1000, new Person(80), new[] { new Person(75) });
            Console.WriteLine($"total weight of car is: {VehicleWeightCalculator.GetTotalWeight(car).ForOutput()}");

            Console.ReadKey();
        }
    }
}
