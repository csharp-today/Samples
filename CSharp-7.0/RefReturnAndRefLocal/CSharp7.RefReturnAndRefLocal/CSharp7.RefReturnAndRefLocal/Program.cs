using System;

namespace CSharp7.RefReturnAndRefLocal
{
    class Program
    {
        static void Main(string[] args) => new Program().Run();

        void Run()
        {
            PrintHeader(2);
            new Example2().ConsumeReference();

            PrintHeader(3);
            new Example3().ConsumeReference();

            Console.WriteLine();
        }

        void PrintHeader(int number) => Console.WriteLine(Environment.NewLine + "Example " + number);
    }
}
