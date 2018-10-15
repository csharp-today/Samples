using System;

namespace CSharp7.ExpressionBodiedMembers
{
    public class Program
    {
        public static void Main(string[] args) => new Program().Run();

        private void Run()
        {
            Console.WriteLine("Examples for article: C# 7.0 - Expression-bodied members");
            Console.WriteLine("Source: https://csharp.today");

            new Example1();
            new Example2();
            GC.Collect();
            new Example3().Run();
            new Example4().Run();
        }
    }
}
