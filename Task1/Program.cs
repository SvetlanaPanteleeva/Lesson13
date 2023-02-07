using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Адрес: СПб, пр-т Металлистов, д.122, лит А.", 45, 12, 25);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Адрес: СПб, Московский проспект, д.185, литер Д.", 50, 14, 32, 10);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
