using System;
using System.IO;
using System.Linq;

namespace CSharp7.Patterns
{
    public class Program
    {
        public static void Main(string[] args) => new Program().Run();

        public void Run()
        {
            Example1();
            Example2();
            Example3();
            Example4();
            Example5();
            Example6();
            Example7();
            Example8();
        }

        private void Example1()
        {
            object obj = 24;

            if (obj is 24)
            {
                Console.WriteLine("Object is 24");
            }

            if (obj is "someValue")
            {
                Console.WriteLine("Object is someValue");
            }
        }

        private void Example2()
        {
            object obj = "someValue";
            switch (obj)
            {
                case 24:
                    Console.WriteLine("Object is 24");
                    break;
                case "someValue":
                    Console.WriteLine("Object is someValue");
                    break;
            }
        }

        private void Example3()
        {
            object obj = Console.Out;

            if (obj is TextWriter writer1)
            {
                writer1.WriteLine("Object is TextWriter");
            }

            switch (obj)
            {
                case TextWriter writer2:
                    writer2.WriteLine("Object is TextWriter");
                    break;
            }
        }

        private void Example4()
        {
            object obj = 24;
            switch (obj)
            {
                case int i when i > 50:
                    Console.WriteLine("More than 50");
                    break;
                case int i when i < 30:
                    Console.WriteLine("Less than 30");
                    break;
                case int i:
                    Console.WriteLine("Other value: " + i);
                    break;
            }
        }

        private static void Log(string message) => Console.WriteLine(message);
        private static bool LogAndEnterClause(string message) { Log(message); return true; }
        private static bool LogAndExitClause(string message) { Log(message); return false; }

        private void Example5()
        {
            Example5_RunSwitchStatementFor(24);
            Example5_RunSwitchStatementFor("csharp.today");
        }

        private void Example5_RunSwitchStatementFor(object obj) 
        {
            switch (obj)
            {
                case int i when LogAndExitClause("Just log that there was int: " + i):
                    Console.WriteLine("This will never be printed");
                    break;
                case string s when LogAndEnterClause("Need to handle string"):
                    Console.WriteLine("Do something with string: " + s);
                    break;
            }
        }

        private void Example6()
        {
            var obj = 24;

            switch (obj)
            {
                case int i when i > 10:
                    // This will catch all int values above 10
                    break;
                case int i when i > 20:
                    // This won't match, because of the above case
                    break;
            }

            switch (obj)
            {
                case int i when i > 20:
                    // Values above 20
                    break;
                case int i when i > 10:
                    // Values: 11-20
                    break;
            }

            switch (obj)
            {
                default:
                    Console.WriteLine("Default case");
                    break;
                case int i:
                    Console.WriteLine("Int case");
                    break;
            }
        }

        private void Example7()
        {
            object obj = null;

            if (obj is null)
            {
                Console.WriteLine("obj is null");
            }

            switch (obj)
            {
                case null:
                    Console.WriteLine("null case");
                    break;
            }

        }

        private void Example8()
        {
            var cusomers = Customer.GetCustomers().ToArray();
            Console.WriteLine("All customers: " + cusomers.Length);

            var selectedCusomers = cusomers
                .Where(c => c.CalculateBonus() is var bonus && bonus > 50 && bonus < 70);
            Console.WriteLine("Premium customers: " + selectedCusomers.Count());
        }
    }
}
