using System.Threading.Tasks;

namespace CSharp7.GeneralizedAsyncReturnTypes
{
    class Example1
    {
        async ValueTask MethodWithoutReturnValue()
        {
            await Task.Delay(1);
        }

        async ValueTask<int> MethodReturningValue()
        {
            await Task.Delay(1);
            return 1;
        }
    }
}
