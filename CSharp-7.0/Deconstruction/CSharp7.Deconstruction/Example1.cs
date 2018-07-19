using System;

namespace CSharp7.Deconstruction
{
    class Example1
    {
        // Let's consider following method
        // Note: For tuple support you need to add System.ValueTuple NuGet
        (string name, int age) GetPerson() => ("John", 24);

        public void Run()
        {
            // Instead of assigning tuple and then use its variables:
            var personTuple = GetPerson();
            Console.WriteLine($"{personTuple.name} is {personTuple.age}");

            // It's fine to assign tuple's values directly - deconstruction
            (string name, int age) = GetPerson();
            Console.WriteLine($"{name} is {age}");
        }
    }
}
