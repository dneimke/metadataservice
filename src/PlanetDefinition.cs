using System;
using System.Collections.Generic;
using System.Text;

namespace MetadataService
{
    public class PlanetDefinition
    {
        public string Name { get; set; }  // constrain to KnownPlanetNames 
        public int Order { get; set; }
    }
}
