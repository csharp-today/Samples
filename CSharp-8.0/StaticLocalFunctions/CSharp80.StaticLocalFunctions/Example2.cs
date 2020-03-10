using System;

namespace CSharp80.StaticLocalFunctions
{
    class Example2
    {
        public void Run() => ParentMethod(7);

        void ParentMethod(int luckyNumber)
        {
            StaticLocalFunction(luckyNumber);

            static void StaticLocalFunction(int value)
            {
                Console.WriteLine($"Static local function with parameter: {value}");
            }
        }
    }
}
