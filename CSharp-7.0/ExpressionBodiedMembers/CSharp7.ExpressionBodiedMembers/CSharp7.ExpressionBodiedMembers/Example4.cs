using System;

namespace CSharp7.ExpressionBodiedMembers
{
    class Example4
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value ?? "";
        }

        public void Run()
        {
            Name = null;
            if (Name is null)
            {
                Console.WriteLine("Name is null");
            }
            else
            {
                Console.WriteLine("Name is not null");
            }
        }
    }
}
