using System;

namespace CSharp7.Tuples
{
    public class Program
    {
        private static void LegacyTuple()
        {
            var person = Tuple.Create("John", 24);
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
        }

        private static void NewTuple()
        {
            var person = ("John", 24);
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
        }

        private static void TupleWithNamedProperties()
        {
            var person = (name: "John", age: 24);
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
        }

        private static (string, int) GetPerson()
        {
            return ("John", 24);
        }

        private static (string name, int age) GetPerson2()
        {
            return ("John", 24);
        }

        (string name, int age) FindOfficer(string division, int rank)
        {
            // some code
            throw new NotImplementedException();
        }

        public static void Main(string[] args)
        {
            //LegacyTuple();
            //NewTuple();
            //TupleWithNamedProperties();

            //var person = GetPerson();
            //Console.WriteLine(person.Item1);
            //Console.WriteLine(person.Item2);

            var person = GetPerson2();
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
        }
    }
}
