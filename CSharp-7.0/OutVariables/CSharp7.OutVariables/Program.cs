using System;

namespace CSharp7.OutVariables
{
    public class Program
    {
        private void Example1()
        {
            var name = "some name";
        }

        // Let's assume we want to call the following method
        private void GetName(out string name) => name = "James Tiberius Kirk";

        private void Example2()
        {
            string name;
            GetName(out name);
            Console.WriteLine(name);
        }

        private void Example3()
        {
            GetName(out string name);
            Console.WriteLine(name);
        }

        private void Example4()
        {
            GetName(out var name);
            Console.WriteLine(name);
        }

        void PrintFutureAge(string ageAsString)
        {
            if (int.TryParse(ageAsString, out var age))
            {
                Console.WriteLine($"In 10 years a person will be {age + 10} years old");
            }
        }

        private void RunExamples()
        {
            Example1();
            Example2();
            Example3();
            Example4();
            PrintFutureAge("24");
        }

        public static void Main(string[] args) => new Program().RunExamples();
    }
}
