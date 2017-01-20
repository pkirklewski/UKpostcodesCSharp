using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DealingWithCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            var records = ProcessCars(@"C:\fuel.csv");
            var document = new XDocument();
            var cars = new XElement("Cars");

            foreach (var record in records)
            {
                var car = new XElement("Car");
                var name = new XElement("Name",record.Name);
                var combined = new XElement("Combined", record.Combined);
                cars.Add(car);
            }


            document.Add(cars);
            document.Save(@"C:\fuel.xml");


        }

        private static List<Car> ProcessCars(string path)
        {
            var query = 
                File.ReadAllLines(path)
                            .Skip(1)
                            .Where(l => l.Length > 1)
                            .ToCar();
            return query.ToList();

        }

        //private static List<Car> ProcessFile(string path)
        //{
        //    //var query =
        //    //    from line in File.ReadAllLines(path)//.Skip(1)
        //    //    //where line.Length > 1
        //    //    //select Car.ParseFromCsv(line);
        //    return query.ToList();
        //}
    }

    public static class CarExtensions
    {
        public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
        {


            // break csv lines into columns

            // CHANGE A
            // CHANGE B
            // CHANGE C
            // CHANGE D
            // CHANGE E
            // CHANGE F

            


            foreach (var line in source)
            {
                 var columns = line.Split(','); // will produce an array from csv

                            yield return new Car
                            {
                                Year = int.Parse(columns[0]),
                                Manufacturer = columns[1],
                                Name = columns[2],
                                Displacement = double.Parse(columns[3]),
                                Cylinders = int.Parse(columns[4]),
                                City = int.Parse(columns[5]),
                                Highway = int.Parse(columns[6]),
                                Combined = int.Parse(columns[7])

                            };
            }
           

        
    }
    }//End of CarExtensions

}
