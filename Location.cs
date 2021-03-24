using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitman3Reworked
{
    class Location
    {
        public string LocationName { get; set; }
        public float YAxis { get; set; }
        public float XAxis { get; set; }
        public float ZAxis { get; set; }

        public Location (string[] locationsFromFile)
        {
            if(locationsFromFile.Count() > 0)
            {
                LocationName = locationsFromFile[0];
                YAxis = float.Parse(locationsFromFile[1]);
                XAxis = float.Parse(locationsFromFile[2]);
                ZAxis = float.Parse(locationsFromFile[3]);
            }
        }
    }
}
