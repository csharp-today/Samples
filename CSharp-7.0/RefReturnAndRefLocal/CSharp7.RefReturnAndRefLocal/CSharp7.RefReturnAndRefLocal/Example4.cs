namespace CSharp7.RefReturnAndRefLocal
{
    class Example4
    {
        ref int ReturnLocalVariable(ref int refParameter)
        {
            int localValue = 7;

            // This won't compile
            // CS8168: Cannot return local 'localValue' by reference because it is not a ref local
            // return ref localValue;

            return ref refParameter;
        }
    }
}
