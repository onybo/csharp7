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

Is operator

        public int GetTotalWeight(object vehicle)
        {
            if (vehicle is Car c)
                return c.Weight + c.Driver.Weight + c.Passengers.Sum(p => p.Weight);
            if (vehicle is Bike b)
                return b.Weight + b.Rider.Weight;

            return 0;
        }

--

Switch on type

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

## Tuples
### When a single result just isn't enough

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


---

The End.