using System;

namespace CSharp7.ExpressionBodiedMembers
{
    class Example3
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public void Run()
        {
            FirstName = "John";
            LastName = "Snow";
            Console.WriteLine("Full name: " + FullName);
        }
    }
}
