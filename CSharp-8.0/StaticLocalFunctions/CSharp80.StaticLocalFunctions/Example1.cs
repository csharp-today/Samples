using System;

namespace CSharp80.StaticLocalFunctions
{
    class Example1
    {
        public void Run() => ParentMethod(7);

        void ParentMethod(int luckyNumber)
        {
            var myNumber = luckyNumber + 2;

            LocalFunction();
            StaticLocalFunction();

            void LocalFunction()
            {
                Console.WriteLine("Local function has access to");
                Console.WriteLine($"* Parent parameter: {luckyNumber}");
                Console.WriteLine($"* Parent variable: {myNumber}");
            }

            static void StaticLocalFunction()
            {
                Console.WriteLine("Static local function - no access");

                // The below line would cause an error
                // myNumber++;
                // Error CS8421: A static local function cannot contain a reference to 'myNumber'.
            }
        }
    }
}
