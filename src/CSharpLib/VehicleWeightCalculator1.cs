using System.Linq;

namespace CSharpLib
{
    public static class VehicleWeightCalculator1
    {
        public static int GetTotalWeight(object vehicle)
        {
            var c = vehicle as Car;
            if (c != null)
                return c.Weight + c.Driver.Weight + c.Passengers.Sum(p => p.Weight);
            var b = vehicle as Bike;
            if (b != null)
                return b.Weight + b.Rider.Weight;

            return 0;
        }
        //if (true == true)
        // if(c.Weight != 10)
        //     return 10;
    }
}
