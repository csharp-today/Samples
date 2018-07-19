using System;

namespace CSharp7.Deconstruction
{
    class Example2
    {
        (string name, int age) GetPerson() => ("John", 24);

        public void Run()
        {
            (var name1, var age1) = GetPerson();
            Console.WriteLine($"{name1} is {age1}");

            var (name2, age2) = GetPerson();
            Console.WriteLine($"{name2} is {age2}");
        }
    }
}
