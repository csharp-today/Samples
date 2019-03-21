namespace CSharp7.RefReturnAndRefLocal
{
    class Example5
    {
        ref string ReturnFixValue(ref string refParameter)
        {
            const string MyConstValue = "ConstValue";

            // All the below won't compile
            // CS8156: An expression cannot be used in this context because it may not be passed or returned by reference

            // return ref "MyValue";
            // return ref null;
            // return ref MyConstValue;

            return ref refParameter;
        }
    }
}
