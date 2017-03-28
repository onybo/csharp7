using System.Linq;

namespace CSharpLib
{
    public static class VehicleWeightCalculator1
    {
        public static int GetTotalWeight(object vehicle)
        {
            if (vehicle is Car c)
                return c.Weight + c.Driver.Weight + c.Passengers.Sum(p => p.Weight);
            if (vehicle is Bike b)
                return b.Weight + b.Rider.Weight;

            return 0;
        }
        //if (true == true)
        // if(c.Weight != 10)
        //     return 10;
    }
}
