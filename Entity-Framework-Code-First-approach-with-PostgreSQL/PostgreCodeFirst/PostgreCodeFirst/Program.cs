using System;
using System.Linq;

namespace PostgreCodeFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new CarContext())
            {
                var owner = new Person
                    {
                        FirstName = "Adam",
                        LastName = "Who"
                    };

                var cars = new[]
                    {
                        new Car { LicenceNumber = "ABC 1234", Insurance = "ABCD" },
                        new Car { LicenceNumber = "CD 54321", Insurance = "XYZ" },
                        new Car { LicenceNumber = "EF 55577", Insurance = "INSURANCE" }
                    };
                foreach (var car in cars)
                {
                    car.Owner = owner;
                    context.Cars.Add(car);
                }
                context.SaveChanges();

                cars = context.Cars.ToArray();
                Console.WriteLine($"We have {cars.Length} car(s).");
                foreach(var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
