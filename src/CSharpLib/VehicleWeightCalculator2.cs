using System;
using System.Linq;

namespace CSharpLib
{
    public static class VehicleWeightCalculator2
    {
        public static int GetTotalWeight(object vehicle)
        {
            switch (vehicle)
            {
                case Car car:
                    return car.Weight + car.Driver.Weight + car.Passengers.Sum(p => p.Weight);
                case SportsCar sc:
                    return sc.Weight + sc.Driver.Weight + sc.Passenger.Weight;
                case Bike b when b.Weight > 0:
                    return b.Weight + b.Rider.Weight;
                case Bike b when b.Weight <= 0:
                    throw new Exception($"Come on, you aren't that thin");
                case Bike b when SunIsShining():
                    throw new Exception($"Sun is shining today so we have no bike weight");
                case null:
                    throw new Exception($"dont know how to calculate weight of nothing");
                case var x:
                    throw new Exception($"dont know how to calculate weight of {x.GetType().Name}");
            }
            //var car = 10;
        }

        private static bool SunIsShining()
        {
            return true;
        }
    }
}
