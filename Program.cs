using System;
using System.Collections.Generic;
using System.Linq;


namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPlanetList = new List<string>();
            
            List<string> planetList = new List<string>() { "Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanetsList = new List<string>() { "Uranus", "Neptune" };

            newPlanetList.AddRange(planetList);
            newPlanetList.AddRange(lastPlanetsList);

            //foreach(var planet in newPlanetList)
            //{
            Console.WriteLine(string.Join(",",newPlanetList));

            //var addNewPlanets = new List<string>() { "Venus", "Earth" };

            newPlanetList.Insert(1, "Venus");
            newPlanetList.Insert(2, "Earth");
            newPlanetList.Add("Pluto");

            Console.WriteLine(string.Join(",", newPlanetList));

            var rockyPlanets = newPlanetList.GetRange(0, 4);


            Console.WriteLine(string.Join(", ", rockyPlanets));
          
            newPlanetList.Remove("Pluto");

            Console.WriteLine(string.Join(",", newPlanetList));

            var spaceCrafts = new Dictionary<string, string>();
            spaceCrafts.Add("Voyager:","Mars, Venus");
            spaceCrafts.Add("Merchant:", "Saturn, Earth");
            spaceCrafts.Add("Artemis:", "Mercury, Jupiter");
            spaceCrafts.Add("Freda:", "Uranus, Neptune");
            spaceCrafts.Add("Enterprise:", "Mars, Venus, Saturn, Earth, Mercury, Jupiter, Uranus, Neptune");

            Console.WriteLine(string.Join("," ,spaceCrafts));

            foreach(var planet in spaceCrafts)
            {
                Console.WriteLine($"{planet.Value} has been visited by the {planet.Key}");
            }




            // }


        }
    }
}
