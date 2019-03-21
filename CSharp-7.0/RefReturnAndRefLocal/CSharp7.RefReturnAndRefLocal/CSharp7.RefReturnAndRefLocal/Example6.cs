using System.Threading.Tasks;

namespace CSharp7.RefReturnAndRefLocal
{
    class Example6
    {
        int[] _values = new[] { 1, 2, 3 };

        // The method signature is not accepted by the compiler
        // CS1073: Unexpected token 'ref'

        //async Task<ref int> AsyncMethod()
        //{
        //    return ref _values[0];
        //}
    }
}
