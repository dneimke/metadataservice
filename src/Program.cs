using System;
using System.Linq;

namespace MetadataService
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new MetadataService();

            var coll = service.GetPlanetDefinitions();

            foreach (var pair in coll.OrderBy(e => e.Value.Size))
            {
                Console.WriteLine(pair.Value);
            }

            Console.WriteLine("----------------------------");
            foreach (var pair in coll.OrderBy(e => e.Value.Order))
            {
                Console.WriteLine($"{pair.Value.Order}) {pair.Key}");
            }

            Console.WriteLine("----------------------------");
            foreach (var pair in coll.OrderBy(e => e.Value.Name))
            {
                Console.WriteLine($"{pair.Value.Order}) {pair.Key}");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"The sort order for Earth is {coll[KnownPlanetNames.Earth].Order}");

            Console.ReadKey();
        }
    }
}
