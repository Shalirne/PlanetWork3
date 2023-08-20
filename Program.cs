using System.Xml.Linq;

namespace Work3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classCall = new PlanetCatalog();
            classCall.GetAPlanet( x =>
            {
                if (x == 3)
                {
                    return "Вы спрашиваете слишком часто";
                }
                else
                {
                    return null;
                }

            },
            x =>
            {
                if (x != "Земля" & x != "Венера" & x != "Марс")
                {
                    return "Это запретная планета";
                }
                else
                {
                    return null;
                }
            }
            , "Чукча", "Лимония", "Марс");
        }
    }
}