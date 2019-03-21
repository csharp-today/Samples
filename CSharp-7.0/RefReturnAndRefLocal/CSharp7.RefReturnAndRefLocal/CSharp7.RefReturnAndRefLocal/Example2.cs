using System;

namespace CSharp7.RefReturnAndRefLocal
{
    class Example2 : Example1
    {
        public void ConsumeReference()
        {
            var collection = new[]
            {
                new BigStruct
                {
                    Text = "My value"
                }
            };

            BigStruct first = GetFirst(collection);

            // Modify
            first.Text = "Changed value";

            // Print
            Console.WriteLine(collection[0].Text);
        }
    }
}
