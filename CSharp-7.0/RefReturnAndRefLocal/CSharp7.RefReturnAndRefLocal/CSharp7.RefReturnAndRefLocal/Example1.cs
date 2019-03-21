namespace CSharp7.RefReturnAndRefLocal
{
    class Example1
    {
        public struct BigStruct
        {
            public int Value1, Value2, Value3;
            public double Double1, Double2;
            public long LongValue;
            public string Text;
        }

        public ref BigStruct GetFirst(BigStruct[] collection)
        {
            return ref collection[0];
        }
    }
}
