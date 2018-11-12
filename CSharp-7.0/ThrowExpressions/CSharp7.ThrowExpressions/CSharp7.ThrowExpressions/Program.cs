using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp7.ThrowExpressions
{
    internal class Program
    {
        internal static void Main(string[] args) => new Program().Run();

        private void Run()
        {
            Console.WriteLine("Examples for article: C# 7.0 - Throw Expressions");
            Console.WriteLine("Source: https://csharp.today");

            Example1(new object());
            Example2(new object());
            Example3(new[] { "name" });
        }

        private object ThrowNullArgumentException(string name)
        {
            throw new ArgumentNullException(name);
        }

        private object Example1(object obj) =>
            obj ?? ThrowNullArgumentException(nameof(obj));

        private object Example2(object obj) =>
            obj ?? throw new ArgumentNullException(nameof(obj));

        private void Example3(IEnumerable<string> names)
        {
            int count =
                names != null
                ? names.Count()
                : throw new ArgumentNullException(nameof(names));
        }
    }
}
