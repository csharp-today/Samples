using System;

namespace CSharp7.ExpressionBodiedMembers
{
    class Example2
    {
        ~Example2() => Console.WriteLine("Expression-bodied finalizer");
    }
}
