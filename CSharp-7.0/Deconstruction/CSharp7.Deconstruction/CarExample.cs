using System;

namespace CSharp7.Deconstruction
{
    public class Car
    {
        public string Model { get; set; }
        public string Owner { get; set; }
    }

    public static class CarExtensions
    {
        public static void Deconstruct(this Car car, out string model, out string owner)
        {
            model = car.Model;
            owner = car.Owner;
        }
    }

    class CarExample
    {
        Car GetCar() => new Car { Model = "Tesla", Owner = "Elon" };

        public void Run()
        {
            // Then we can deconstruct the car
            var (model, owner) = GetCar();
            Console.WriteLine($"{model} belongs to {owner}");
        }
    }
}
