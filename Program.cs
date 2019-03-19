using System;
using System.Collections.Generic;

namespace dict_solarsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() {"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Neptune", "Uranus"};

            List<Dictionary<string, string>> probeList = new List<Dictionary<string, string>>() {
                new Dictionary<string, string>(){ {"Jupiter", "Pioneer 11"} },
                new Dictionary<string, string>(){ {"Jupiter", "Pioneer 10"} },
                new Dictionary<string, string>(){ {"Saturn", "Voyager 1"} },
                new Dictionary<string, string>(){ {"Uranus", "Voyager 2"} },
                new Dictionary<string, string>(){ {"Jupiter", "Galileo"} },
                new Dictionary<string, string>(){ {"Jupiter", "Ulysses"} },
                new Dictionary<string, string>(){ {"Saturn", "Cassini-Huygens"} },
                new Dictionary<string, string>(){ {"Jupiter", "New Horizons"} },
                new Dictionary<string, string>(){ {"Jupiter", "Juno"} },
                new Dictionary<string, string>(){ {"Jupiter", "Jupiter Icy Moons Explorer"} },
                new Dictionary<string, string>(){ {"Jupiter", "Europa Clipper"} }
            };

            foreach (string planet in planetList)
            {
                List<string> matchingProbes = new List<string>();

                foreach (Dictionary<string, string> probe in probeList)
                {
                    if (probe.ContainsKey(planet))
                    {
                        matchingProbes.Add(probe[planet]);
                    }
                }

                string probeString = "no probes";

                if (matchingProbes.Count > 0)
                {
                    probeString = String.Join(", ", matchingProbes) ?? "none";
                }
                Console.WriteLine($"{planet}: {probeString}");
            }

        }
    }
}
