using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib
{
    public class LocalFunctions
    {
        public static void DoPerson(Person person)
        {
            if (person == null) throw new ArgumentNullException(nameof(person));
            Log<Person>(person);

            void Log<T>(Person p)
            {
                Console.WriteLine($"vehicletype: {typeof(T).Name}. Weight: {p.Weight}");
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

        public static void DoPerson2()
        {
            var person = new Person(80);
            Log();
            Log();
            Log();

            void Log()
            {
                Console.WriteLine($"Weight: {person.Weight}");
                person.Weight += 20;                
            }
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
