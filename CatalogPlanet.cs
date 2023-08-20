using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    internal class PlanetCatalog
    {
        public List<string> catalog = new List<string>();
        public delegate string PlanetValidator(string name);
        public delegate string Lyambda(int x);
        public delegate string LyambdaX(string x);
        public int Timer = 0;

        public static string PlanetValidatorData(string name)
        {
            if (name != "Земля" & name != "Венера" & name != "Марс")
            {
                return "Планеты не найдено";
            }
            return "Планета найдена";
        }


        public void GetAPlanet(Lyambda lyambda, LyambdaX lyambdaX, params string[] Planets)
        {

            foreach (string planet in Planets)
            {
                catalog.Add(planet);
            }
            foreach (var item in catalog)
            {
                string examination = lyambdaX(item);
                if (examination != null)
                {
                    Console.WriteLine($"Планета - {item} - {examination}");
                    continue;
                }
                Timer += 1;
                string timer = lyambda(Timer);
                if (timer != null)
                {
                    Console.WriteLine(timer);
                    break;
                }    
                var selectedPlanet = GetAPlanetData(item, PlanetValidatorData);
                if (selectedPlanet.Error == "Планеты не найдено")
                {
                    Console.WriteLine(item);
                    Console.WriteLine(selectedPlanet.Error);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Название планеты - {item}");
                    Console.WriteLine($"Длина Экватора {selectedPlanet.EquatorLength}");
                    Console.WriteLine($"Порядковый номер от солнца {selectedPlanet.SerialNumber}");
                    Console.WriteLine();
                }
            }
        }

        public (int SerialNumber, int EquatorLength, string Error) GetAPlanetData(string name, PlanetValidator planetValidatorData)
        {
            var planetValidator = planetValidatorData(name);
            if (planetValidator == "Планеты не найдено")
            {
                return (0, 0, planetValidator);
            }
            else
            {
                var planetData = new Planet();
                planetData.name = name;
                var serialNumber = planetData.serialNumber;
                var equatorLength = planetData.equatorLength;
                return (serialNumber, equatorLength, "");
            }
        }
    }
}