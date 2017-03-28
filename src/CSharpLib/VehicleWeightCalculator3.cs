using System.Linq;

namespace CSharpLib
{
    public static class VehicleWeightCalculator
    {
        public static (int weight, Result result) GetTotalWeight(object vehicle)
        {
            switch (vehicle)
            {
                case Car car:
                    return (car.Weight + car.Driver.Weight + car.Passengers.Sum(p => p.Weight), Result.Success);
                case SportsCar sc:
                    return (sc.Weight + sc.Driver.Weight + sc.Passenger.Weight, Result.Success);
                case Bike b:
                    return (b.Weight + b.Rider.Weight, Result.Success);
                case var x:
                    return (0, Result.Failure($"dont know how to calculate weight of {x.GetType().Name}"));
            }
        }
    }
}
