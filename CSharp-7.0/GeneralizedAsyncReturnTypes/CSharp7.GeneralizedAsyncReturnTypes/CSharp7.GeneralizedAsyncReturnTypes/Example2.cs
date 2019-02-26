using System.Threading.Tasks;

namespace CSharp7.GeneralizedAsyncReturnTypes
{
    class Example2
    {
        public async ValueTask<string> GetNameAsync(int id)
        {
            if (TryGetNameFromCache(id, out var name))
            {
                return name;
            }

            name = await GetNameFromDatabaseAsync(id);
            AddToCache(id, name);
            return name;
        }

        private void AddToCache(int id, string name) { }

        private async Task<string> GetNameFromDatabaseAsync(int id)
        {
            await Task.Delay(1);
            return "value";
        }

        private bool TryGetNameFromCache(int id, out string name)
        {
            name = null;
            return false;
        }
    }
}
