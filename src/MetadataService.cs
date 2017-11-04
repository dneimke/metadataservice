using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetadataService
{
    public class MetadataService
    {
        public Dictionary<string, PlanetDefinition> GetPlanetDefinitions()
        {
            return GetList().ToDictionary(e => e.Name, e => e);
        }


        private List<PlanetDefinition> GetList()
        {
            var list = new List<PlanetDefinition>
            {
                new PlanetDefinition { Name = KnownPlanetNames.Mercury, Order = 1, Color = "Gray", Size = 2440 },
                new PlanetDefinition { Name = KnownPlanetNames.Venus, Order = 2, Color = "Pale Yellow", Size = 6052 },
                new PlanetDefinition { Name = KnownPlanetNames.Earth, Order = 3, Color = "Blue with White Clouds", Size = 6371 },
                new PlanetDefinition { Name = KnownPlanetNames.Mars, Order = 4, Color = "Reddish Brown", Size = 3390 },
                new PlanetDefinition { Name = KnownPlanetNames.Jupiter, Order = 5, Color = "Orange and White bands", Size = 69911 },
                new PlanetDefinition { Name = KnownPlanetNames.Saturn, Order = 6, Color = "Pale Gold", Size = 58232 },
                new PlanetDefinition { Name = KnownPlanetNames.Uranus, Order = 7, Color = "Pale Blue", Size = 25362 },
                new PlanetDefinition { Name = KnownPlanetNames.Neptune, Order = 8, Color = "Pale Blue", Size = 24622 },
            };

            return list;
        }
    }
}
