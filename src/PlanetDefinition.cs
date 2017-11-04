using System;
using System.Collections.Generic;
using System.Text;

namespace MetadataService
{
    public class PlanetDefinition
    {
        public string Name { get; set; }  // constrain to KnownPlanetNames 
        public int Order { get; set; }
        public string Color { get; set; } // src: http://curious.astro.cornell.edu/about-us/58-our-solar-system/planets-and-dwarf-planets/planet-watching/249-what-color-is-each-planet-intermediate
        public int Size { get; set; } // src: https://www.universetoday.com/36649/planets-in-order-of-size/

        public override string ToString()
        {
            return $"{Name} - {Color} ({Size}km)";
        }
    }
}
