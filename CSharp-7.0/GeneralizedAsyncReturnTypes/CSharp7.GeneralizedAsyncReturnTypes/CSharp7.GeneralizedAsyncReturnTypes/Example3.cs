using System.Threading.Tasks;

namespace CSharp7.GeneralizedAsyncReturnTypes
{
    class Example3
    {
        Task<int> GetValueWithTask() => Task.FromResult(0);

        ValueTask<int> GetValueWithValueTask() => new ValueTask<int>(0);

        ValueTask<int> GetValue()
        {
            // This won't compile
            // CS0029: Cannot implicitly convert type 'System.Threading.Tasks.Task<int>' to 'System.Threading.Tasks.ValueTask<int>'

            // return GetValueWithTask();

            return GetValueWithValueTask();
        }

        async ValueTask<int> GetValueAsync()
        {
            // But this will work fine
            return await GetValueWithTask();
        }
    }
}
