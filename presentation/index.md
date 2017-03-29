---
theme : "night"
transition: "default"
---
## C# 7 features

---

- Patterns
  - Is pattern
  - Switch pattern
- Local functions
- Tuples
- Deconstruction
- Out variables
- Literals
- More expression bodied members


Note: test note

---

## Patterns

Is and Switch

--

Example - calculating the weight
![class diagram](classes.png)

--

### Is operator - the old way

        public int GetTotalWeight(object vehicle)
        {
            var c = vehicle as Car;
            if (c != null)
                return c.Weight + c.Driver.Weight + c.Passengers.Sum(p => p.Weight);

            var b = vehicle as Bike;
            if (b != null)
                return b.Weight + b.Rider.Weight;

            return 0;
        }

--

### Is operator

        public int GetTotalWeight(object vehicle)
        {
            if (vehicle is Car c)
                return c.Weight + c.Driver.Weight + c.Passengers.Sum(p => p.Weight);
            if (vehicle is Bike b)
                return b.Weight + b.Rider.Weight;

            return 0;
        }

--

### Switch on type

        public int GetTotalWeight(object vehicle)
        {
            switch (vehicle)
            {
                case Car car:
                    return car.Weight + car.Driver.Weight + car.Passengers.Sum(p => p.Weight);
                case SportsCar sc:
                    return sc.Weight + sc.Driver.Weight + sc.Passenger.Weight;
                case Bike b:
                    return b.Weight + b.Rider.Weight;
                case var x:
                    throw new Exception($"dont know how to calculate weight of {x.GetType().Name}");
            }
        }


--
Branching on types in OO?

---

## Local Functions

--

# Skipping param validation

        public static void DoPerson(Person person)
        {
            if (person == null) throw new ArgumentNullException(nameof(person));
            Log<Person>(person);

            void Log<T>(Person p)
            {
                Console.WriteLine($"vehicletype: {typeof(T).Name}. Weight: {p.Weight}");
            }
        }


---

## Tuples
### When a single result just isn't enough

--

Predefined type 'System.ValueTuple`2' is not defined or imported

add nuget package: System.ValueTuple

--
Return tuple

        public static (int, HttpStatusCode) CallService1()
        {
            //do the call and get result and status code
            return (2, HttpStatusCode.OK);
        }

--
Named tuple elements

        public static (int value, HttpStatusCode statusCode) CallService1()
        {
            //do the call and get result and status code
            return (2, HttpStatusCode.OK);
        }

--
Tuple Deconstruction

        public static void DeconstructTuple()
        {
            var (val, code) = CallService1();
            Console.WriteLine($"Value is {val}. Code is {code}");
        }
--
Only field types matters for overloads

        public static void TupleParam((int code, string mesg) val)
        {
            Console.WriteLine(val.Item1 + " : " + val.Item2);
        }

        public static void TupleParam((string val, string text) val)
        {
            Console.WriteLine(val.val + " : " + val.Item2);
        }

---

The End.