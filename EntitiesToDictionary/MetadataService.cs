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
                new PlanetDefinition { Name = KnownPlanetNames.Mercury, Order = 1 },
                new PlanetDefinition { Name = KnownPlanetNames.Venus, Order = 2 },
                new PlanetDefinition { Name = KnownPlanetNames.Earth, Order = 3 },
                new PlanetDefinition { Name = KnownPlanetNames.Mars, Order = 4 },
                new PlanetDefinition { Name = KnownPlanetNames.Jupiter, Order = 5 },
                new PlanetDefinition { Name = KnownPlanetNames.Saturn, Order = 6 },
                new PlanetDefinition { Name = KnownPlanetNames.Uranus, Order = 7 },
                new PlanetDefinition { Name = KnownPlanetNames.Neptune, Order = 8 },
            };

            return list;
        }
    }
}
