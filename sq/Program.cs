using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sq
{
    class Program
    {
        static int Main(string[] args)
        {

            string[] cities = { "Warsaw","Boston","Los Angeles","Seattle","London","New York","Ludwikowice", "Ludwikowice Podgórne"};

IEnumerable<string> filteredCities =
                from city in cities
                where city.StartsWith("L") && city.Length < 150
                orderby city
                select city;
Console.WriteLine("Query  Syntax \n==================");
            foreach (var city in filteredCities){
            Console.WriteLine(city);
            }
      
            Console.WriteLine("\nMethod Syntax \n==================");

            foreach (var city in cities.Where(c => c.StartsWith("L") && c.Length < 150).OrderBy(c=>c))
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();

            return 0;
        }
    }
}
