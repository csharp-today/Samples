using System;

namespace CSharp7.RefReturnAndRefLocal
{
    class Example7 : Example1
    {
        public void ReassignRefLocal()
        {
            var collection = new[]
            {
                new BigStruct
                {
                    Text = "My value"
                }
            };

            // Create ref local and assign
            ref BigStruct first = ref GetFirst(collection);

            // Reassign won't compile in C# 7.0
            // CS8107: Feature 'ref reassignment' is not available in C# 7.0. Please use language version 7.3 or greater.
            // first = ref GetFirst(collection);
        }
    }
}
