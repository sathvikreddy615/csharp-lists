using System;
using System.Collections.Generic;


namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanetsList = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastPlanetsList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

            Dictionary<string, string> viking = new Dictionary<string, string>();
            viking["Mars"] = "Viking";

            Dictionary<string, string> oppurtunity = new Dictionary<string, string>(){{"Mars", "Oppurtunity"}};

            Dictionary<string, string> mariner10 = new Dictionary<string, string>();
            mariner10["Mercury"] = "Mariner10";

            probes.Add(viking);
            probes.Add(oppurtunity);
            probes.Add(mariner10);

            foreach (string planet in planetList)
            {
                List<string> visitedProbes = new List<string>();

                foreach (Dictionary<string, string> probe in probes)
                {
                    if (probe.ContainsKey(planet)) {
                        visitedProbes.Add(probe[planet]);
                    }                    
                }
                // Output the name of the planet and comma seperateed list of matching probes
                if (visitedProbes.Count > 0) 
                {
                    Console.WriteLine($"{planet}: {String.Join(", ", visitedProbes)}");
                }
            }
        }
    }
}
