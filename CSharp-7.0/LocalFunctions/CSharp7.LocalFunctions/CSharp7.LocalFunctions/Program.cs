using System;
using System.Collections.Generic;

namespace CSharp7.LocalFunctions
{
    public class Program
    {
        public static void Main(string[] args) => new Program().Run();

        private void Run()
        {
            Console.WriteLine("Examples for blog article: C# 7.0 - Local functions");

            Example1();
            Example2("MyName", 24);
            Example3();
            Example4();
        }

        private void Example1()
        {
            Print("Starting long running operation");
            // Do some work
            Print("Operation finished");

            void Print(string message)
            {
                var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Console.WriteLine($"[{timestamp}] >>> {message}");
            }
        }

        private void Example2(string name, int value)
        {
            PrintName();

            int newValue = value + 100;
            PrintValues();

            void PrintName()
            {
                Console.WriteLine("Name: " + name);
            }

            void PrintValues()
            {
                Console.WriteLine("Old value: " + value);
                Console.WriteLine("New value: " + newValue);
            }
        }

        private void Example3()
        {
            PrintAll();

            void PrintAll()
            {
                PrintHeader();
                PrintLine("Line 1");
                PrintLine("One more line");
            }

            void PrintHeader() => Console.WriteLine("Header line");

            void PrintLine(string line) => Console.WriteLine("Line: " + line);
        }

        private void Example4()
        {
            IEnumerable<TOutput> Convert<TInput, TOutput>(IEnumerable<TInput> source, Func<TInput, TOutput> convertFunction)
            {
                // Evaluate arguments
                if (source == null)
                {
                    throw new ArgumentNullException(nameof(source));
                }
                if (convertFunction == null)
                {
                    throw new ArgumentNullException(nameof(convertFunction));
                }

                // Call iterator method
                return ConvertIterator();

                IEnumerable<TOutput> ConvertIterator()
                {
                    foreach (var inputItem in source)
                    {
                        var outputItem = convertFunction(inputItem);
                        yield return outputItem;
                    }
                }
            }

            // The following call will only evaluate arguments
            var output = Convert(new[] { 1, 10, 100 }, i => i.ToString());
            // The foreach loop will cause ConvertIterator method to be called
            foreach (var item in output)
            {
                Console.WriteLine("Item: " + item);
            }
        }
    }
}
