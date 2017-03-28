using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib
{
    public class LocalFunctions
    {
        public static int GetTotalWeight(object vehicle)
        {
            void Log<T>(int weight)
            {
                Console.WriteLine($"vehicletype: {typeof(T).Name}. Weight: {weight}");
            }

            switch (vehicle)
            {
                case Car car:
                    Log<Car>(car.Weight);
                    return car.Weight + car.Driver.Weight + car.Passengers.Sum(p => p.Weight);
                case SportsCar sc:
                    return sc.Weight + sc.Driver.Weight + sc.Passenger.Weight;
                case Bike b when b.Weight > 0:
                    return b.Weight + b.Rider.Weight;
                default:
                    return 0;
            }
        }

        public static void NamePersons()
        {
            var persons = new[] { new Person(40), new Person(50), new Person(60) };
            var count = 0;
            foreach (var p in persons)
            {
                count++;
                NamePerson();

                void NamePerson()
                {
                    p.Name = $"name{count}";
                }
            }

            persons
                .ToList()
                .ForEach(p => Console.WriteLine(p.Name));
        }

        public static async Task NamePersonsA()
        {
            var tasks = new List<Task>();
            var persons = new[] { new Person(40), new Person(50), new Person(60) };
            var count = 0;
            foreach(var p in persons)
            {
                count++;
                tasks.Add(NamePerson());

                async Task NamePerson()
                {
                    await Task.Delay(2000);
                    p.Name = $"name{count}";
                }
            }

            await Task.WhenAll(tasks.ToArray());
            persons
                .ToList()
                .ForEach(p => Console.WriteLine(p.Name));

        }
    }
}
