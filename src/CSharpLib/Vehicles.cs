using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib
{
    public class Person
    {
        public Person(int weight)
        {
            Weight = weight;
        }

        public int Weight { get; private set; }
        public string Name { get; internal set; }
    };

    public class Car
    {
        public Car(int weight, Person driver, IEnumerable<Person> passengers)
        {
            Weight = weight;
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));                
            Passengers = passengers?.ToArray() ?? throw new ArgumentNullException(nameof(passengers));
        }
        public Person[] Passengers { get; private set; }
        public Person Driver { get; private set; }
        public int Weight { get; private set; }
    }

    public class SportsCar
    {
        public SportsCar(int weight, Person driver, Person passenger)
        {
            Weight = weight;
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            Passenger = passenger ?? throw new ArgumentNullException(nameof(passenger));
        }
        public Person Passenger { get; private set; }
        public Person Driver { get; private set; }
        public int Weight { get; private set; }
    }

    public class Bike
    {
        public Bike(int weight, Person rider)
        {
            Weight = weight;
            Rider = rider ?? throw new ArgumentNullException(nameof(rider));
        }
        public Person Rider { get; private set; }
        public int Weight { get; private set; }
    }
}
