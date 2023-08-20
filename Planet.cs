using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    internal class Planet
    {
        public string name { get; set; }

        public int serialNumber
        {
            get
            {
                if (name == "Венера")
                {
                    return 2;
                }
                if (name == "Земля")
                {
                    return 3;
                }
                if (name == "Марс")
                {
                    return 4;
                }
                return default(int);
            }
        }
        public int equatorLength
        {
            get
            {
                if (name == "Венера")
                {
                    return 38025;
                }
                if (name == "Земля")
                {
                    return 40075;
                }
                if (name == "Марс")
                {
                    return 21344;
                }
                return default(int);
            }
        }
        public string previousPlanet { get; }
    }
}